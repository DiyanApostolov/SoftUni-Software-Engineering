using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique 
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> box = new Stack<int>();

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int racks = 0;

            foreach (var item in nums)
            {
                box.Push(item);
            }

            if (box.Sum() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (box.Count != 0)
                {
                    int currClotes = box.Pop();
                    if (sum + currClotes <= capacity)
                    {
                        sum += currClotes;
                        if (sum == capacity)
                        {
                            sum = 0;
                            racks++;
                        }
                    }
                    else
                    {
                        if (sum + currClotes > capacity)
                        {
                            racks++;
                        }
                        sum = currClotes;
                    }
                }
                if (sum > 0)
                {
                    racks++;
                }
                Console.WriteLine(racks == 0 ? 0 : racks);
            }
        }
    }
}      
