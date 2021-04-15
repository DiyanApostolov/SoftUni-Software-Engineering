using System;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|").ToArray();

            int health = 100;
            int bitcoins = 0;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] currentIndex = input[i].Split(" ").ToArray();
                string monster = currentIndex[0];
                string number = currentIndex[1];
                counter++;

                int damage = int.Parse(number);

                if (monster == "potion")
                {
                    int currentHealt = health;
                    health += damage;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    int healed = health - currentHealt;

                    Console.WriteLine($"You healed for {healed} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (monster == "chest")
                {
                    bitcoins += damage;
                    Console.WriteLine($"You found {damage} bitcoins.");
                }
                else
                {
                    health -= damage;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {counter}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }               
            }
            
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
