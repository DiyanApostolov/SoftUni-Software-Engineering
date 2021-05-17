using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string currentRow = reader.ReadLine();
                int row = 0;

                while (currentRow != null)
                {
                    if (row % 2 == 0)
                    {
                        string replacedRow = ReplaceSymbols(currentRow);

                        var reversedRow = replacedRow
                            .Split()
                            .Reverse()
                            .ToArray();

                        Console.WriteLine(string.Join(' ', reversedRow));
                    }

                    row++;
                    
                    currentRow = reader.ReadLine();
                }
            }
        }

        private static string ReplaceSymbols(string currentRow)
        {
            return currentRow
                        .Replace("-", "@")
                        .Replace(",", "@")
                        .Replace(".", "@")
                        .Replace("!", "@")
                        .Replace("?", "@");
        }
    }
}
