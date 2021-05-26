using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLenght = int.Parse(Console.ReadLine());

            Func<string, bool> filterFunc = x => x.Length <= nameLenght;

            List<string> names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(filterFunc)
                .ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
