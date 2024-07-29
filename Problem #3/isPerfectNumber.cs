

using System;


namespace Main
{
    internal class Program
    {

        static int ReadPositiveNumber(string Message)
        {
            int Number = 0;
            do
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine();
                int.TryParse(input, out Number);
            } while (Number <= 0);
            return Number;
        }

        static bool isPerfectNumber(int Number)
        {
            int Sum = 0;

            for (int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                    Sum += i;
            }

            return Number == Sum;
        }


        static void PrintResults(int Number)
        {
            if (isPerfectNumber(Number))
                Console.WriteLine($"{Number} is Perfect Number.");
            else
                Console.WriteLine($"{Number} NOT is Perfect Number.");
        }


        static void Main(string[] args)
        {

            PrintResults(ReadPositiveNumber("Please enter a positive number: "));
        }
    }
}

