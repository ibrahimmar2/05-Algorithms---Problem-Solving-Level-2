

using System;


namespace Main
{
    internal class Program
    {

        static void Header()
        {
            Console.WriteLine("\n\t\t\tMultipiaction Table From 1 to 10\n");
            Console.Write("\t");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\n___________________________________________________________________________________"); ;
        }

        static string ColumSperator(int i)
        {
            if (i < 10)
                return "   |";
            else
                return "  |";
        }

        static void PrintMultipiactionTable()
        {
            Header();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(" " + i + ColumSperator(i) + "\t");

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {

            PrintMultipiactionTable();

        }
    }
}

