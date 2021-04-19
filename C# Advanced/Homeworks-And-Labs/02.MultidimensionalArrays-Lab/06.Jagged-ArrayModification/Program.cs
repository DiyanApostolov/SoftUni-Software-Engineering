using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    jaggedArray[row][col] = rowData[col];
                }
            }

            string[] cmdArg = Console.ReadLine().Split();

            while (cmdArg[0] != "END")
            {
                string command = cmdArg[0];
                int row = int.Parse(cmdArg[1]);
                int col = int.Parse(cmdArg[2]);
                int value = int.Parse(cmdArg[3]);

                if (row < n && row >= 0 && col < n && col >= 0)
                {
                    if (command == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                cmdArg = Console.ReadLine().Split();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
