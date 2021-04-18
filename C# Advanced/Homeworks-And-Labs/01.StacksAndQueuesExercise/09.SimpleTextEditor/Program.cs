using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var textVersions = new Stack<string>();
            var text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {               
                string command = Console.ReadLine();

                var tokens = command
                    .Split()
                    .ToArray();

                if (command.StartsWith("1"))
                {
                    textVersions.Push(text.ToString());
                    string textToAppend = command.Substring(2).Replace(" ", "");
                    text.Append(textToAppend);
                }
                else if (command.StartsWith("2"))
                {
                    textVersions.Push(text.ToString());

                    int count = int.Parse(tokens[1]);

                    text.Remove(text.Length - count, count);
                }
                else if (command.StartsWith("3"))
                {
                    int index = int.Parse(tokens[1]) - 1;

                    if (index >= 0 && index < text.Length)
                    {
                        Console.WriteLine(text[index]);
                    }
                }
                else if (command.StartsWith("4"))
                {
                    text.Clear();
                    text.Append(textVersions.Pop());
                }
            }
        }
    }
}
