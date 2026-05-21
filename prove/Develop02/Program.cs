using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        string filename;
        //JournalEntry myJournalEntry = new JournalEntry();
        //myJournalEntry.CreateJournalEntry();
        // myJournalEntry.DisplayJournalEntry();
        // Console.WriteLine(myJournalEntry.CreateFileSystemString());

        Journal myJournal = new();
        //myJournal.AddJournalEntry(myJournalEntry);

        //myJournal.DisplayJournal();

        string response = "";
        while(response != "Q" && response != "q")
        {
            Console.WriteLine("Welcome to the menu! What would you like to do?");
            Console.WriteLine("[1] See previous entries.");
            Console.WriteLine("[2] Record a new entry with a random prompt.");
            Console.WriteLine("[3] Save Journal to a file.");
            Console.WriteLine("[4] Load Journal from a file.");
            Console.WriteLine("[Q] Quit");
            Console.Write("Response: ");
            response = Console.ReadLine();
            if (response == "1")
            {
                Console.WriteLine("Here is your list of entries!: ");
                myJournal.DisplayJournal();
                Console.Write("Would you like to [Q]uit? (Press Enter to Continue): ");
                response = Console.ReadLine();
            }
            else if (response == "2")
            {
                string continueWriting = "";
                while(continueWriting != "N" && continueWriting != "n")
                {
                    JournalEntry journalEntry = new();
                    Console.WriteLine("Here is your random journal entry: ");
                    journalEntry.CreateJournalEntry();
                    myJournal.AddJournalEntry(journalEntry);
                    Console.Write("Would you like to write another? [Y]/[N]: ");
                    continueWriting = Console.ReadLine();
                }
                Console.Write("Would you like to [Q]uit? (Press Enter to Continue): ");
                response = Console.ReadLine();
            }
            else if (response == "3")
            {
                //Grabs user provided name of the file
                Console.Write("What would you like to name the file?: ");
                filename = Console.ReadLine();
                //Parses the file by lines
                using (StreamWriter outputFile = new StreamWriter(filename + ".csv"))
                {
                    outputFile.WriteLine("Date,Prompt,Response");
                    foreach(JournalEntry journalEntry in myJournal._journalEntries)
                    {
                        outputFile.WriteLine(journalEntry.CreateFileCsv());
                    }
                }
                Console.Write("Would you like to [Q]uit? (Press Enter to Continue): ");
                response = Console.ReadLine();
            }
            else if (response == "4")
            {
                //Grabs user provided name of the file
                Console.Write("What is the name of the file? (case sensitive): ");
                filename = Console.ReadLine();
                //Parses the file by lines
                string [] lines = System.IO.File.ReadAllLines(filename);
                //Clears the list of journal entries in journal in case some have been saved
                myJournal._journalEntries.Clear();
                foreach(string line in lines.Skip(1))
                {
                    string[] parts = line.Split(",");
                    JournalEntry journalEntry = new();
                    journalEntry._date = parts[0].Trim('"');
                    journalEntry._prompt = parts[1].Trim('"');
                    journalEntry._response = parts[2].Trim('"');
                    myJournal._journalEntries.Add(journalEntry);
                }
                Console.Write("Would you like to [Q]uit? (Press Enter to Continue): ");
                response = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Thank you for your time!");
            }
        }

    }
}