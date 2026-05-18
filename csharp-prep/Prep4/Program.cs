using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = 1;
        List<int> userNumbers = new List<int>();
        while(userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            if(userNumber != 0){userNumbers.Add(userNumber);}
        }
        int sum = 0;
        int largestNum = 0;
        foreach (int num in userNumbers)
        {
            sum += num;
            if(num > largestNum){largestNum = num;}
        }
        int listLength = userNumbers.Count;
        int average = sum / listLength;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}