using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string> printer = Print;

            foreach (var name in input)
            {
                printer(name);
            }
        }

        private static void Print(string text)
        {
            Console.WriteLine($"Sir {text}"); ;
        }
    }
}
