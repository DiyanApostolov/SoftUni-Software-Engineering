using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> output = new Dictionary<string, int>(); 

            using (StreamReader reader = new StreamReader("../../../Words.txt"))
            {
                string[] words = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    output.Add(word.ToLower(), 0);
                }

                using (StreamReader readInput = new StreamReader("../../../Input.txt"))
                {
                    string line = readInput.ReadToEnd();

                    string patternt = @"[A-Za-z]+";

                    foreach (Match m in Regex.Matches(line, patternt))
                    {
                        string currentWord = m.Value.ToLower();

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (currentWord == words[i])
                            {
                                output[currentWord]++;
                            }
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                foreach (var kvp in output.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
