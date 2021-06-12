using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesOfOrcs = int.Parse(Console.ReadLine());
            int[] aragornsDefense = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> plates = new Queue<int>(aragornsDefense);
            Stack<int> orcs = null;
            bool isEnd = false;

            for (int i = 1; i <= wavesOfOrcs; i++)
            {
                int[] waveOfOrcs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                orcs = new Stack<int>(waveOfOrcs);

                if (i % 3 == 0)
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(extraPlate);
                }

                for (int j = 0; j < waveOfOrcs.Length; j++)
                {
                    if (plates.Count == 0 || orcs.Count == 0)
                    {
                        isEnd = true;
                        break;
                    }

                    if (orcs.Peek() > plates.Peek())
                    {
                        int woundedOrc = orcs.Pop() - plates.Dequeue();
                        orcs.Push(woundedOrc);
                    }
                    else if (plates.Peek() > orcs.Peek())
                    {
                        int damagedPlate = plates.Dequeue() - orcs.Pop();
                        plates.Enqueue(damagedPlate);

                        for (int k = 0; k < plates.Count - 1; k++)
                        {
                            plates.Enqueue(plates.Dequeue());
                        }
                    }
                    else
                    {
                        plates.Dequeue();
                        orcs.Pop();
                    }
                }

                if (isEnd)
                {
                    break;
                }
            }

            if (orcs.Count == 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
