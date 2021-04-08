using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            PrintNumbersOfVowel(input);
        }

        public static void PrintNumbersOfVowel(string input) 
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == 'a')
                {
                    counter++;
                }
                if (currentChar == 'e')
                {
                    counter++;
                }
                if (currentChar == 'i')
                {
                    counter++;
                }
                if (currentChar == 'o')
                {
                    counter++;
                }
                if (currentChar == 'u')
                {
                    counter++;
                }
            }
            
            Console.WriteLine(counter);
        }
    }
}
