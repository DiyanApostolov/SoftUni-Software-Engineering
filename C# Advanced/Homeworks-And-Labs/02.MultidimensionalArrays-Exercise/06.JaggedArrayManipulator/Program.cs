using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] matrix = new double [n][];

            for (int row = 0; row < n; row++)
            {
                double[] rowdata = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                matrix[row] = rowdata;
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = 0; j < matrix[row].Length; j++)
                        {
                            matrix[i][j] *= 2;
                        }
                    }
                }
                else
                {
                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            matrix[i][j] /= 2;
                        }
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(cmdArg[1]);
                int col = int.Parse(cmdArg[2]);
                int value = int.Parse(cmdArg[3]);

                if (cmdArg[0] == "Add")
                {
                    if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (cmdArg[0] == "Subtract")
                {
                    if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
