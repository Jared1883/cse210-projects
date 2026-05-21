public class JournalEntry
{
    
    public string _date;

    public string _prompt;

    public string _response;

    public List<String> _prompts = new()
    {
        "What was the strongest emotion I felt today?",
        "Who was the most interesting person I interacted with today?",
        "How did you see the hand of God in your life today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I'd want to tell my current/future kids about today?"
    };

    public void CreateJournalEntry ()
    {
        //Gets current date:
        _date = DateTime.Now.ToShortDateString();
        //Random number:
        Random rng = new Random();
        //Selects a random prompt
        _prompt = _prompts[rng.Next(0, (_prompts.Count - 1))];
        //Spits out the prompt in the console
        Console.Write($"{_prompt}: ");
        //Saves the response
        _response = Console.ReadLine();
    }
    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
    public string CreateFileCsv()
    {
        string date = $"\"{_date}\"";
        string prompt = $"\"{_prompt.Replace("\"", "\"\"")}\"";
        string response = $"\"{_response.Replace("\"", "\"\"")}\"";
        return $"{date},{prompt},{response}";
    }

}