using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[1];

                if (command == "joined")
                {
                    string vloggerName = cmdArg[0];

                    if (!dict.ContainsKey(vloggerName))
                    {
                        dict.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        dict[vloggerName].Add("followers", new HashSet<string>());
                        dict[vloggerName].Add("following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string firstVlogger = cmdArg[0];
                    string secondVlogger = cmdArg[2];

                    if (dict.ContainsKey(firstVlogger) && dict.ContainsKey(secondVlogger) && firstVlogger != secondVlogger)
                    {
                        dict[firstVlogger]["following"].Add(secondVlogger);
                        dict[secondVlogger]["followers"].Add(firstVlogger);
                    }
                }

                input = Console.ReadLine();
            }

            int count = 1;

            Console.WriteLine($"The V-Logger has a total of {dict.Count} vloggers in its logs.");

            foreach (var vlogger in dict.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
}