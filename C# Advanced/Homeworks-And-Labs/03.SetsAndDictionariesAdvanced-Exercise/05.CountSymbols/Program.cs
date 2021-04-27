using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charactersCount = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (!charactersCount.ContainsKey(character))
                {
                    charactersCount[character] = 1;
                }
                else
                {
                    charactersCount[character]++;
                }
            }

            foreach (var kvp in charactersCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
