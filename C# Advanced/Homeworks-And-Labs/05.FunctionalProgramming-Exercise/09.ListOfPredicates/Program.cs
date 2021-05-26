using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numbers = Enumerable.Range(1, range).ToList();

            Func<int, int, bool> predicate =
                (num, d) => num % d == 0;

            foreach (int num in numbers)
            {
                if (dividers.All(d => predicate(num, d)))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
