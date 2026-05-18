using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
        int userNumber = 0;
        while(userNumber != number)
        {
            Console.WriteLine("Hello user, try to guess my number!");
            Console.Write("What is your guess?: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            if(userNumber > number)
            {
                Console.WriteLine("Guess lower!");
            }
            if(userNumber < number)
            {
                Console.WriteLine("Guess higher!");
            }
        }
        
    }
}