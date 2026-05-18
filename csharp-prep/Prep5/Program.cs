using System;
using System.Globalization;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string response = Console.ReadLine();
        return response;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int response = int.Parse(Console.ReadLine());
        return response;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num)
    {
        int square = num * num;
        return square;
    }

    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        int yearsOld = DateTime.Now.Year - year;
        Console.WriteLine($"{name}, you will turn {yearsOld} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int square = SquareNumber(number);
        DisplayResult(name, square, birthYear);
    }
}