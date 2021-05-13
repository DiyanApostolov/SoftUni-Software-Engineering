using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                string currentRow = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    int counter = 1;
                    while (currentRow != null)
                    {
                        writer.WriteLine($"{counter}. " + currentRow);
                        counter++;

                        currentRow = reader.ReadLine();
                    }
                }
            }
        }
    }
}
