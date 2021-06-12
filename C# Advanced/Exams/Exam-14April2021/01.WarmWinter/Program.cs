using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hatsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] scarfsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> hats = new Stack<int>(hatsInput);
            Queue<int> scarfs = new Queue<int>(scarfsInput);
            List<int> sets = new List<int>();

            while (hats.Any() && scarfs.Any())
            {
                if (hats.Peek() > scarfs.Peek())
                {
                    int currentSet = hats.Pop() + scarfs.Dequeue();
                    sets.Add(currentSet);
                }
                else if (scarfs.Peek() > hats.Peek())
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    int currentHat = hats.Pop() + 1;
                    hats.Push(currentHat);
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(' ', sets));
        }
    }
}
