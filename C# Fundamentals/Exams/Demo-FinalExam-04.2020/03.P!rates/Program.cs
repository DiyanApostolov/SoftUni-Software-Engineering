using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    class Program
    {
        public class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }
        }
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();

            while (true)
            {
                string[] command = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Sail")
                {
                    break;
                }

                City city = cities.FirstOrDefault(c => c.Name == command[0]);

                if (city != null)
                {
                    city.Name = command[0];
                    city.Population += int.Parse(command[1]);
                    city.Gold += int.Parse(command[2]);
                }
                else
                {
                    city = new City();
                    city.Name = command[0];
                    city.Population = int.Parse(command[1]);
                    city.Gold = int.Parse(command[2]);
                    cities.Add(city);
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                City currentCity = cities.FirstOrDefault(c => c.Name == command[1]);

                if (command[0] == "Plunder")
                {
                    currentCity.Population -= int.Parse(command[2]);
                    currentCity.Gold -= int.Parse(command[3]);
                    Console.WriteLine($"{currentCity.Name} plundered! {command[3]} gold stolen, {command[2]} citizens killed.");

                    if (currentCity.Population <= 0 || currentCity.Gold <= 0)
                    {
                        Console.WriteLine($"{currentCity.Name} has been wiped off the map!");
                        cities.Remove(currentCity);
                    }
                }
                else if (command[0] == "Prosper")
                {
                    if (int.Parse(command[2]) < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        currentCity.Gold += int.Parse(command[2]);
                        Console.WriteLine($"{int.Parse(command[2])} gold added to the city treasury. {currentCity.Name} now has {currentCity.Gold} gold.");
                    }
                }
            }

            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

            foreach (var city in cities.OrderByDescending(c => c.Gold).ThenBy(c => c.Name))
            {
                Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
            }
        }
    }
}
