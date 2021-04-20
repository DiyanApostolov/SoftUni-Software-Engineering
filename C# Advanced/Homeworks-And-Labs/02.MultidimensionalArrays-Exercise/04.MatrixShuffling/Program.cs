using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (cmdArg[0] != "END")
            {
                if (cmdArg[0] == "swap")
                {
                    int row1 = int.Parse(cmdArg[1]);
                    int col1 = int.Parse(cmdArg[2]);
                    int row2 = int.Parse(cmdArg[3]);
                    int col2 = int.Parse(cmdArg[4]);


                    if (isValidCell(row1, row2, col1, col2, rows, cols))
                    {
                        string currentElement = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = currentElement;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                printMatrix(matrix, rows, cols);

                cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void printMatrix(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            };
        }

        private static bool isValidCell(int row1, int row2, int col1, int col2, int rows, int cols)
        {
            return row1 >= 0 && row1 < rows && row2 >= 0 && row2 < rows &&
                   col1 >= 0 && col1 < cols && col2 >= 0 && col2 < cols ? true : false;
        }
    }
}
