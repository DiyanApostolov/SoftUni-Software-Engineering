using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emoticonPattern = @"(?<name>([*]{2})[A-Z][a-z]{2,}([*]{2})|([:]{2})[A-Z][a-z]{2,}([:]{2}))";
            string coolPattern = @"\d";

            var coolMatches = Regex.Matches(input, coolPattern);
            string numbers = String.Join("", coolMatches);
            int coolness = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = int.Parse(numbers[i].ToString());
                coolness *= num;
            }

            var emoticonsMatches = Regex.Matches(input, emoticonPattern);
            List<string> emoticons = new List<string>();

            foreach (Match item in emoticonsMatches)
            {
                string currMatch = item.ToString();
                string currEmoticon = currMatch.Substring(2, currMatch.Length - 4);
                int currCoolness = 0;

                for (int i = 0; i < currEmoticon.Length; i++)
                {
                    int number = currEmoticon[i];
                    currCoolness += number;
                }

                if (currCoolness > coolness)
                {
                    emoticons.Add(currMatch);
                }
            }

            Console.WriteLine($"Cool threshold: {coolness}");
            Console.WriteLine($"{emoticonsMatches.Count} emojis found in the text. The cool ones are:");
            foreach (var item in emoticons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
