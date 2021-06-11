using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksValues = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] threadsValues = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> tasks = new Stack<int>(tasksValues);
            Queue<int> threads = new Queue<int>(threadsValues);

            int taskToKill = int.Parse(Console.ReadLine());
            int killer = 0;

            while (true)
            {
                int threadTask = threads.Peek();
                int currentTask = tasks.Peek();

                if (currentTask == taskToKill)
                {
                    killer = threadTask;
                    break;
                }
                else if (threadTask >= currentTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else 
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {killer} killed task {taskToKill}");
            Console.WriteLine(string.Join(' ', threads));
        }
    }
}
