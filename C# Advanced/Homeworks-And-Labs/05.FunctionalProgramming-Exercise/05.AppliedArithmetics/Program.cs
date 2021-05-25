using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            Func<List<int>, List<int>> func = n =>
            {
                List<int> newNumbers = new List<int>();

                if (command == "add")
                {
                    foreach (var item in n)
                    {
                        newNumbers.Add(item + 1);
                    }
                }
                else if (command == "multiply")
                {
                    foreach (var item in n)
                    {
                        newNumbers.Add(item * 2);
                    }
                }
                else if (command == "subtract")
                {
                    foreach (var item in n)
                    {
                        newNumbers.Add(item - 1);
                    }
                }

                return newNumbers;
            }; 

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                    case "multiply":
                    case "subtract":
                        numbers = func(numbers);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(' ', numbers));
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
