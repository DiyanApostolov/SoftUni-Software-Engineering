using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArg[0];
                string criteria = cmdArg[1];
                string argument = cmdArg[2];

                if (command == "Remove")
                {
                    Predicate<string> predicate = GetPredicate(criteria, argument);

                    guests.RemoveAll(predicate);
                }
                else if (command == "Double")
                {
                    Func<string, bool> filterFunc = GetFilter(criteria, argument);
                    List<string> filteredNames = guests.Where(filterFunc).ToList();

                    guests.InsertRange(0, filteredNames);
                }

                input = Console.ReadLine();
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

        private static Func<string, bool> GetFilter(string criteria, string argument)
        {
            if (criteria == "StartsWith")
            {
                return x => x.StartsWith(argument);
            }
            else if (criteria == "EndsWith")
            {
                return x => x.EndsWith(argument);
            }
            else if (criteria == "Length")
            {
                return x => x.Length == int.Parse(argument);
            }
            else
            {
                return x => true;
            }
        }

        private static Predicate<string> GetPredicate(string criteria, string argument)
        {
            if (criteria == "StartsWith")
            {
                return x => x.StartsWith(argument);
            }
            else if (criteria == "EndsWith")
            {
                return x => x.EndsWith(argument);
            }
            else if (criteria == "Length")
            {
                return x => x.Length == int.Parse(argument);
            }
            else
            {
                return x => true;
            }
        }
    }
}
