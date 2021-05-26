using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int[], int, List<int>> reverseAndExclude = (arr, n) => 
            {
                Array.Reverse(arr);
                List<int> list = new List<int>();

                foreach (var num in arr)
                {
                    if (num % n != 0)
                    {
                        list.Add(num);
                    }
                }

                return list;
            };

            Console.WriteLine(string.Join(' ', reverseAndExclude(input, n)));
        }
    }
}
