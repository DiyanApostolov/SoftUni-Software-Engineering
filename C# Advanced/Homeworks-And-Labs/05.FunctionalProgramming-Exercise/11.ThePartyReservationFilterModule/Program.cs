using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> removedGuests = new List<string>();

            string input = Console.ReadLine();

            while (input != "Print")
            {
                string[] cmdArg = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArg[0];
                string filterType = cmdArg[1];
                string filterParameter = cmdArg[2];

                if (command == "Add filter")
                {
                    Predicate<string> predicate = GetPredicate(filterType, filterParameter);

                    removedGuests.AddRange(guests.Where(g => predicate(g)));
                    guests.RemoveAll(predicate);
                }
                else if (command == "Remove filter")
                {
                    Func<string, bool> filterFunc = GetFilter(filterType, filterParameter);

                    guests.AddRange(removedGuests.Where(filterFunc));
                }

                input = Console.ReadLine();
            }

            Action<List<string>> print =
                list =>
                {
                    foreach (string guest in list)
                    {
                        Console.Write(guest + " ");
                    }
                };

            print(guests);
        }

        private static Func<string, bool> GetFilter(string filterType, string filterParameter)
        {
            if (filterType == "Starts with")
            {
                return x => x.StartsWith(filterParameter);
            }
            else if (filterType == "Ends with")
            {
                return x => x.EndsWith(filterParameter);
            }
            else if (filterType == "Length")
            {
                return x => x.Length == int.Parse(filterParameter);
            }
            else if (filterType == "Contains")
            {
                return x => x.Contains(filterParameter);
            }
            else
            {
                return x => true;
            }
        }

        private static Predicate<string> GetPredicate(string filterType, string filterParameter)
        {
            if (filterType == "Starts with")
            {
                return x => x.StartsWith(filterParameter);
            }
            else if (filterType == "Ends with")
            {
                return x => x.EndsWith(filterParameter);
            }
            else if (filterType == "Length")
            {
                return x => x.Length == int.Parse(filterParameter);
            }
            else if (filterType == "Contains")
            {
                return x => x.Contains(filterParameter);
            }
            else
            {
                return x => true;
            }
        }
    }
}
