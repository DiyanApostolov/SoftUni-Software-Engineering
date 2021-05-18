using System;

namespace _01.ActionPoint
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
            Console.WriteLine(text); ;
        }
    }
}
