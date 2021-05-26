using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>, string, string> removeGuest =
                (list, criteria, argument) => 
                {
                    if (criteria == "StartsWith")
                    {
                        guests = guests.Where(g => !g.StartsWith(argument)).ToList();
                    }
                    else if (criteria == "EndsWith")
                    {
                        guests = guests.Where(g => !g.EndsWith(argument)).ToList();
                    }
                    else if (criteria == "Lenght")
                    {
                        int lenght = int.Parse(argument);
                        guests = guests.Where(g => g.Length != lenght).ToList();
                    }
                };
            Action<List<string>, string, string> doubleGuest =
                (list, criteria, argument) =>
                {
                    if (criteria == "StartsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)  
                        {
                            if (guests[i].StartsWith(argument))
                            {
                                guests.Insert(i + 1, guests[i]);
                                i++;
                            }
                        }
                    }
                    else if (criteria == "EndsWith")
                    {
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].EndsWith(argument))
                            {
                                guests.Insert(i + 1, guests[i]);
                                i++;
                            }
                        }
                    }
                    else if (criteria == "Length")
                    {
                        int lenght = int.Parse(argument);
                        for (int i = 0; i < guests.Count; i++)
                        {
                            if (guests[i].Length == lenght)
                            {
                                guests.Insert(i + 1, guests[i]);
                                i++;
                            }
                        }
                    } 
                };

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string criteria = cmdArg[1];
                string argument = cmdArg[2];

                if (cmdArg[0] == "Remove")
                {
                    removeGuest(guests, criteria, argument);
                }
                else if (cmdArg[0] == "Double")
                {
                    doubleGuest(guests, criteria, argument);
                }

                command = Console.ReadLine();
            }

            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
