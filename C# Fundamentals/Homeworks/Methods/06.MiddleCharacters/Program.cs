using System;
using System.Linq;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        private static void PrintMiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                int half = input.Length / 2;
                Console.WriteLine($"{input[half-1]}{input[half]}");
            }
            else
            {
                int half = input.Length / 2;
                Console.WriteLine(input[half]);
            }
        }
    }
}
