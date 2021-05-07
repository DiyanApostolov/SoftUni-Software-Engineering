using System;
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

            Queue<int> liquids = new Queue<int>();
            Stack<int> ingredients = new Stack<int>();

            int[] liquidsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ingredientsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < liquidsInput.Length; i++)
            {
                liquids.Enqueue(liquidsInput[i]);
                ingredients.Push(ingredientsInput[i]);
            }

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
                    food["Bread"] += 1;
                }
                else if (sum == cake)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    food["Cake"] += 1;
                }
                else if (sum == pastry)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    food["Pastry"] += 1;
                }
                else if (sum == fruitPie)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    food["Fruit Pie"] += 1;
                }
                else
                {
                    liquids.Dequeue();
                    int currIngredients = ingredients.Pop() + 3;
                    ingredients.Push(currIngredients);
                }
            }

            if (food["Bread"] > 0 && food["Cake"] > 0 && food["Pastry"] > 0 && food["Fruit Pie"] > 0)
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
