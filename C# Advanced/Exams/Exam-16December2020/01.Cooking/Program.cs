﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int bread = 25;
            int cake = 50;
            int pastry = 75;
            int fruitPie = 100;

            int[] liquidsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ingredientsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(liquidsInput);
            Stack<int> ingredients = new Stack<int>(ingredientsInput);

            var food = new SortedDictionary<string, int>();
            food.Add("Bread", 0);
            food.Add("Cake", 0);
            food.Add("Pastry", 0);
            food.Add("Fruit Pie", 0);

            while (liquids.Any() && ingredients.Any())
            {
                int sum = liquids.Peek() + ingredients.Peek();

                if (sum == bread)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    food["Bread"]++;
                }
                else if (sum == cake)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    food["Cake"]++;
                }
                else if (sum == pastry)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    food["Pastry"]++;
                }
                else if (sum == fruitPie)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    food["Fruit Pie"]++;
                }
                else
                {
                    liquids.Dequeue();
                    int currIngredients = ingredients.Pop() + 3;
                    ingredients.Push(currIngredients);
                }
            }

            if (food["Bread"] >= 1 && food["Cake"] >= 1 && food["Pastry"] >= 1 && food["Fruit Pie"] >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");

            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }

            foreach (var item in food)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
