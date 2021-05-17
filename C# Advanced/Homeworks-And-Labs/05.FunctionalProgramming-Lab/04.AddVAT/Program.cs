using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> priceWithVAT = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.20)
                .ToList();

            foreach (var price in priceWithVAT)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}