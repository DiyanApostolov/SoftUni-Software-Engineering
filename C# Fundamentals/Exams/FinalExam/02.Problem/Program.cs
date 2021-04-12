using System;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"(\*|@)([A-Z][a-z]{2,})\1: \[([A-Za-z])\]\|\[([A-Za-z])\]\|\[([A-Za-z])\]\|$");
            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[2].Value;
                    int firstLetter = Convert.ToChar(match.Groups[3].Value);
                    int secondLetter = Convert.ToChar(match.Groups[4].Value);
                    int thirdLetter = Convert.ToChar(match.Groups[5].Value);

                    Console.WriteLine($"{name}: {firstLetter} {secondLetter} {thirdLetter}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
