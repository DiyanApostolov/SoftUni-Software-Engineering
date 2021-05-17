using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textLines = File.ReadAllLines("../../../text.txt");
            string[] words = File.ReadAllLines("../../../words.txt");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowercaseWord = word.ToLower();

                if (!wordsCount.ContainsKey(lowercaseWord))
                {
                    wordsCount.Add(lowercaseWord, 0);
                }
            }

            foreach (var line in textLines)
            {
                string[] currentRow = line.ToLower().Split(new char[] { ' ', '-', ',', '!', '?', '.', '\'' });

                foreach (var currentWord in currentRow)
                {
                    if (wordsCount.ContainsKey(currentWord))
                    {
                        wordsCount[currentWord]++;
                    }
                }
            }

            string actualResultPath = "../../../actualResult.txt";
            string expectedResultPath = "../../../expectedResult.txt";

            foreach (var kvp in wordsCount)
            {
                File.AppendAllText(actualResultPath, $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
            }

            foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
            }
        }
    }
}
