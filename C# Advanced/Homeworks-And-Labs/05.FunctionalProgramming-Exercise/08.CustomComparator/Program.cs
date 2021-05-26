using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> sortFunc = (x, y) =>
                (x % 2 == 0 && y % 2 != 0) ? -1
                : (x % 2 != 0 && y % 2 == 0) ? 1
                : x > y ? 1 : x < y ? -1 : 0;

            Array.Sort(inputNumbers, (x, y) => sortFunc(x, y));

            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
