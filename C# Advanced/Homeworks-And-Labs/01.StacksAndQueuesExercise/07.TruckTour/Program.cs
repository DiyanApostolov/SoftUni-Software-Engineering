using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var difference = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] cmdArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int amountOfPetrol = cmdArg[0];
                int distanceToNextPump = cmdArg[1];

                difference.Enqueue(amountOfPetrol - distanceToNextPump);
            }

            int index = 0;

            while (true)
            {
                var copyDifference = new Queue<int>(difference);

                int fuel = int.MinValue;

                while (copyDifference.Any())
                {
                    int currentDiffernce = copyDifference.Peek();

                    if (currentDiffernce > 0 && fuel == int.MinValue)
                    {
                        fuel = copyDifference.Dequeue();
                        difference.Enqueue(difference.Dequeue());
                    }
                    else if (currentDiffernce < 0 && fuel == int.MinValue)
                    {
                        copyDifference.Enqueue(copyDifference.Dequeue());
                        difference.Enqueue(difference.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copyDifference.Dequeue();

                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }

                index++;
            }
        }
    }
}
