using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> times = new Dictionary<double, int>();

            foreach (var item in input)
            {
                if (!times.ContainsKey(item))
                {
                    times.Add(item, 0);
                }

                times[item]++;
            }

            foreach (var item in times)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
