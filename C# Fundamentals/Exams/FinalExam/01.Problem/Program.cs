using System;
using System.Linq;

namespace _01.Problem

{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string command = cmdArg[0];

            while (command != "End")
            {
                if (command == "Translate")
                {
                    string oldChar = cmdArg[1];
                    input = input.Replace(oldChar, cmdArg[2]);
                    Console.WriteLine(input);
                }
                else if (command == "Includes")
                {
                    string someString = cmdArg[1];
                    Console.WriteLine(input.Contains(someString));
                }
                else if (command == "Start")
                {
                    string start = cmdArg[1];
                    Console.WriteLine(input.StartsWith(start));
                }
                else if (command == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command == "FindIndex")
                {
                    string findIndex = cmdArg[1];
                    int index = input.LastIndexOf(findIndex);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int count = int.Parse(cmdArg[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }

                cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                command = cmdArg[0];
            }
        }
    }
}
