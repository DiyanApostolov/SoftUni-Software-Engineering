using System;
using System.Collections.Generic;
using System.IO;

namespace _4.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = new List<string>();

            using (StreamReader firstInput = new StreamReader("../../../Input1.txt"))
            {
                using (StreamReader secondInput = new StreamReader("../../../Input2.txt"))
                {
                    string firstRow = firstInput.ReadLine();
                    string secondRow = secondInput.ReadLine();

                    while (firstRow != null || secondRow != null)
                    {
                        lines.Add(firstRow);

                        if (secondRow != null)
                        {
                            lines.Add(secondRow);
                        }

                        firstRow = firstInput.ReadLine();
                        secondRow = secondInput.ReadLine();
                    }
                }
            }

            using (StreamWriter output = new StreamWriter("../../../Output.txt"))
            {
                foreach (var line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}
