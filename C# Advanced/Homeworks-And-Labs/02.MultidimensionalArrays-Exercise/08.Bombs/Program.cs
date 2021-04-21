using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] cellsCoordinates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cellsCoordinates.Length; i++)
            {
                int[] cellData = cellsCoordinates[i].Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int row = cellData[0];
                int col = cellData[1];

                if (matrix[row, col] > 0)
                {
                    matrix = Explode(row, col, matrix, n);
                }
            }

            int aliveCells = 0;
            int sum = 0;

            foreach (int item in matrix)
            {
                if (item > 0)
                {
                    aliveCells++;
                    sum += item;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix, n);
        }

        private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] Explode(int row, int col, int[,] matrix, int n)
        {
            int[,] newMatrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }

            int bombPower = newMatrix[row, col];

            if (bombPower > 0)
            {
                newMatrix[row, col] -= bombPower;

                if (row - 1 >= 0 && newMatrix[row - 1, col] > 0) // up
                {
                    newMatrix[row - 1, col] -= bombPower;
                }
                if (row - 1 >= 0 && col - 1 >= 0 && newMatrix[row - 1, col - 1] > 0) // up left
                {
                    newMatrix[row - 1, col - 1] -= bombPower;
                }
                if (row - 1 >= 0 && col + 1 < n && newMatrix[row - 1, col + 1] > 0) // up right
                {
                    newMatrix[row - 1, col + 1] -= bombPower;
                }
                if (row + 1 < n && newMatrix[row + 1, col] > 0) // down
                {
                    newMatrix[row + 1, col] -= bombPower;
                }
                if (row + 1 < n && col - 1 >= 0 && newMatrix[row + 1, col - 1] > 0) // down left
                {
                    newMatrix[row + 1, col - 1] -= bombPower;
                }
                if (row + 1 < n && col + 1 < n && newMatrix[row + 1, col + 1] > 0) // down right
                {
                    newMatrix[row + 1, col + 1] -= bombPower;
                }
                if (col - 1 >= 0 && newMatrix[row, col - 1] > 0) // left
                {
                    newMatrix[row, col - 1] -= bombPower;
                }
                if (col + 1 < n && newMatrix[row, col + 1] > 0) // right
                {
                    newMatrix[row, col + 1] -= bombPower;
                }
            }

            return newMatrix;
        }
    }
}
