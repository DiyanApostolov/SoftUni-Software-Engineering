using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Person
    {
         public Person(string name, int health, int energy)
          {
               Name = name;
               Health = health;
               Energy = energy;
          }

           public string Name { get; set; }
           public int Health { get; set; }
           public int Energy { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string[] cmdArg = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

            while (cmdArg[0] != "Results")
            {
                string command = cmdArg[0];
                
                if (command == "Add")
                {
                    string name = cmdArg[1];
                    int health = int.Parse(cmdArg[2]);
                    int energy = int.Parse(cmdArg[3]);

                    if (persons.Any(p => p.Name == name))
                    {
                        var item = persons.SingleOrDefault(p => p.Name == name);
                        int index = persons.IndexOf(item);
                        persons[index].Health += health;
                    }
                    else
                    {
                        Person person = new Person(name, health, energy);
                        persons.Add(person);
                    }
                }
                else if (command == "Attack")
                {
                    string attackerName = cmdArg[1];
                    string defenderName = cmdArg[2];
                    int damage = int.Parse(cmdArg[3]);

                    if (persons.Any(p => p.Name == attackerName && persons.Any(p => p.Name == defenderName)))
                    {
                        var attacker = persons.SingleOrDefault(p => p.Name == attackerName);
                        var defender = persons.SingleOrDefault(p => p.Name == defenderName);
                        int indexA = persons.IndexOf(attacker);
                        int indexD = persons.IndexOf(defender);
                        persons[indexA].Energy -= 1;
                        persons[indexD].Health -= damage;

                        if (persons[indexD].Health <= 0)
                        {
                            Console.WriteLine($"{defenderName} was disqualified!");
                            persons.Remove(defender);
                        }

                        indexA = persons.IndexOf(attacker);

                        if (persons[indexA].Energy <= 0)
                        {
                            Console.WriteLine($"{attackerName} was disqualified!");
                            persons.Remove(attacker);
                        }
                    }

                }
                else if (command == "Delete")
                {
                    string name = cmdArg[1];

                    if (persons.Any(p => p.Name == name))
                    {
                        var item = persons.SingleOrDefault(p => p.Name == name);
                        persons.Remove(item);
                    }
                    else if (name == "All")
                    { 
                        persons = new List<Person>();
                    }
                }

                cmdArg = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"People count: {persons.Count}");

            foreach (var person in persons
            .OrderByDescending(p => p.Health)
            .ThenBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Health} - {person.Energy}");
            }
        }
    }
}
