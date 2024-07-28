

using System;

enum enPrimNotPrime { Prime = 1, NotPrime = 2 };

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

        static enPrimNotPrime CheckPrime(int Number)
        {
            int M = (int)Math.Round(Number / 2.0);

            for (int Counter = 2; Counter <= M; Counter++)
            {
                if (Number % Counter == 0)
                {
                    return enPrimNotPrime.NotPrime;

                }
            }     
           
            return enPrimNotPrime.Prime;
        }


        static void PrintPrimeNumbersFrom1ToN(int Number)
        {
            Console.WriteLine($"\nPrime Numbers From 1 to {Number} are:");

            for (int i = 1; i <= Number; i++)
            {
                if (CheckPrime(i) == enPrimNotPrime.Prime)
                {
                    Console.WriteLine(i);
                }
            }
        }


        static void Main(string[] args)
        {

            PrintPrimeNumbersFrom1ToN(ReadPositiveNumber("Please enter a positive number: "));
        }
    }
}

