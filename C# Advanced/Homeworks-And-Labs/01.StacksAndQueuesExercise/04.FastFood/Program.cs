using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> orders = new Queue<int>();

            int quantityFoodToServe = int.Parse(Console.ReadLine());

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var item in nums)
            {
                orders.Enqueue(item);
            }

            Console.WriteLine(orders.Max());

            int counter = orders.Count;
            
            for (int i = 0; i < counter; i++)
            {
                if (orders.Peek() <= quantityFoodToServe)
                {
                    quantityFoodToServe -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
