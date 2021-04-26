using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                char first = input[0];

                if (input.Length == 8 && char.IsDigit(first))
                {
                   vipGuests.Add(input);
                }
                else if (input.Length == 8)
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            string guest = Console.ReadLine();

            while (guest != "END")
            {
                if (vipGuests.Contains(guest))
                {
                    vipGuests.Remove(guest);
                }
                else if (regularGuests.Contains(guest))
                {
                    regularGuests.Remove(guest);
                }

                guest = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regularGuests)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
