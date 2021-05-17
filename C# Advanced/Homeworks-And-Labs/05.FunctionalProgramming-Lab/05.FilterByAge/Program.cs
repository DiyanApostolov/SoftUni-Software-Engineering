using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);

                people.Add(name, age);
            }

            string condition = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            string criterion = Console.ReadLine();

            var output = FilterByAge(people, condition, ageLimit);

            PrintOutput(output, criterion);
        }

        private static void PrintOutput(Dictionary<string, int> output, string criterion)
        {
            if (criterion == "name age")
            {
                foreach (var people in output)
                {
                    Console.WriteLine($"{people.Key} - {people.Value}");
                }
            }
            else
            {
                foreach (var people in output)
                {
                    if (criterion == "name")
                    {
                        Console.WriteLine(people.Key);
                    }
                    else if (criterion == "age")
                    {
                        Console.WriteLine(people.Value);
                    }
                }
            }
            
        }

        private static Dictionary<string, int> FilterByAge(Dictionary<string, int> people, string condition, int ageLimit)
        {
            if (condition == "older")
            {
                Dictionary<string, int> output = people.Where(p => p.Value >= ageLimit).ToDictionary(k => k.Key, v=> v.Value);
                return output;
            }
            else
            {
                Dictionary<string, int> output = people.Where(p => p.Value < ageLimit).ToDictionary(k => k.Key, v => v.Value);
                return output;
            }
        }
    }
}
