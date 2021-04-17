using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x =>int.Parse(x)).ToArray();
            Queue<int> queue = new Queue<int>(input);
            int count = queue.Count(); 
            
            for (int i = 0; i < count; i++)           
            {                
                if (queue.Peek() % 2 == 1)
                {                    
                    queue.Dequeue();
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }    
            }
            
            Console.WriteLine(string.Join(", ",queue));
        }
    }
}
