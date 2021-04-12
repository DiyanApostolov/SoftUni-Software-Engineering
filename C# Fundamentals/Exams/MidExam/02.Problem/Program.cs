using System;
using System.Collections.Generic;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> weaponName = new List<string>();

            foreach (var item in input)
            {
                weaponName.Add(item);
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Done")
            {
                if (command[0] == "Move")
                {
                    if (command[1] == "Left")
                    {
                        int index = int.Parse(command[2]);
                        if (index > 0 && index < weaponName.Count)
                        {
                            weaponName.Insert(index - 1, weaponName[index]);
                            weaponName.RemoveAt(index + 1);
                        }
                    }
                    else 
                    {
                        int index = int.Parse(command[2]);
                        if (index >= 0 && index < weaponName.Count - 1)
                        {
                            weaponName.Insert(index + 2, weaponName[index]);
                            weaponName.RemoveAt(index);
                        }
                    }
                }
                else if (command[0] == "Check")
                {
                    if (command[1] == "Even")
                    {
                        for (int i = 0; i < weaponName.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write($"{weaponName[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < weaponName.Count; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Console.Write($"{weaponName[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"You crafted {string.Join("", weaponName)}!");
        }
    }
}
