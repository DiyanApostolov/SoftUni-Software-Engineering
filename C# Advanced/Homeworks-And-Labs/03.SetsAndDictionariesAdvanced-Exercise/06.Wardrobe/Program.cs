using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wadrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if (!wadrobe.ContainsKey(color))
                {
                    wadrobe.Add(color, new Dictionary<string, int>());
                }

                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentClothe = clothes[j].Trim();

                    if (!wadrobe[color].ContainsKey(currentClothe))
                    {
                        wadrobe[color].Add(currentClothe, 1);
                    }
                    else
                    {
                        wadrobe[color][currentClothe] += 1;
                    }
                }
            }

            string[] searchClothe = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wadrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothe in color.Value)
                {
                    Console.Write($"* {clothe.Key} - {clothe.Value}");

                    if (color.Key == searchClothe[0] && clothe.Key == searchClothe[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
