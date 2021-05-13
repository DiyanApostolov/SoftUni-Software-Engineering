using System;
using System.IO;

namespace _1.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                string currentRow = reader.ReadLine();
                int row = 0;

                while (currentRow != null)
                {
                    if (row % 2 == 1)
                    {
                        Console.WriteLine(currentRow);
                    }

                    currentRow = reader.ReadLine();
                    row++;
                }
            }
        }
    }
}
