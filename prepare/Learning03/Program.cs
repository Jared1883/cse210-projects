using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many loops would you like?: ");
        int loopNum = int.Parse(Console.ReadLine());
        int fractionNum = 0;
        while(loopNum > 0)
        {
            Random rng = new();
            int randomTop = rng.Next(1,5);
            int randomBottom = rng.Next(1,5);
            Fraction fraction = new(randomTop, randomBottom);
            string fractionString = fraction.GetFractionString();
            double fractionDecimal = fraction.GetDecimalValue();
            Console.WriteLine($"Fraction {fractionNum}: string: {fractionString} Number: {fractionDecimal}");
            fractionNum++;
            loopNum--;
        }
    }
}