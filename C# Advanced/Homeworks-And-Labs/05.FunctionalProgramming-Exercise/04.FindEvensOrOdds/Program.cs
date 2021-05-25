using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = bounds[0];
            int end = bounds[1];

            Func<int, int, List<int>> generateRageOfNums = (s, e) =>
            {
                List<int> nums = new List<int>();

                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateRageOfNums(start, end);

            Predicate<int> predicate = n => true;

            string criteria = Console.ReadLine();

            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (criteria == "even")
            {
                predicate = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(' ', MyWhere(numbers, predicate)));
        }

        private static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (var curNum in numbers)
            {
                if (predicate(curNum))
                {
                    newNumbers.Add(curNum);
                }
            }

            return newNumbers;
        }
    }
}
