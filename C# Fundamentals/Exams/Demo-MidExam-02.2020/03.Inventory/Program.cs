using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] command = input.Split(" - ").ToArray();

                if (command[0] == "Collect")
                {
                    if (inventory.Contains(command[1]) == false)
                    {
                        inventory.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (inventory.Contains(command[1]))
                    {
                        inventory.Remove(command[1]);
                    }
                }
                else if (command[0] == "Combine Items")
                {
                    string[] combine = command[1].Split(':').ToArray();

                    if (inventory.Contains(combine[0]))
                    {
                        int counter = 0;
                        foreach (string item in inventory)
                        {
                            if (item == combine[0])
                            {
                                break;
                            }
                            counter++;
                        }
                        inventory.Insert(counter + 1, combine[1]);
                    }
                }
                else if (command[0] == "Renew")
                {
                    if (inventory.Contains(command[1]))
                    {
                        inventory.Remove(command[1]);
                        inventory.Add(command[1]);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
