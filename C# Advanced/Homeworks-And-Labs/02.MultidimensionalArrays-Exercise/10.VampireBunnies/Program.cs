using System;
using System.Linq;

namespace _10.VampireBunnies
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

            char[,] matrix = new char[rows, cols];

            int playerRow = int.MinValue;
            int playerCol = int.MinValue;

            for (int row = 0; row < rows; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (rowData[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                        matrix[playerRow, playerCol] = '.';
                    }
                }
            }

            string directions = Console.ReadLine();

            for (int i = 0; i < directions.Length; i++)
            {
                char direction = directions[i];
                int oldPlayerRow = playerRow;
                int oldPlayerCol = playerCol;

                switch (direction)
                {
                    case 'L': playerCol--; break;
                    case 'R': playerCol++; break;
                    case 'U': playerRow--; break;
                    case 'D': playerRow++; break;
                }

                matrix = SpreadBunnies(matrix, rows, cols);

                if (playerRow < 0 || playerRow >= rows || 
                    playerCol < 0 || playerCol >= cols)
                {
                    PrintResult(matrix, oldPlayerRow, oldPlayerCol, "won");
                    break;
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    PrintResult(matrix, playerRow, playerCol, "dead");
                    break;
                }
            }
        }

        private static char[,] SpreadBunnies(char[,] matrix, int rows, int cols)
        {
            char[,] newMatrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    newMatrix[row, col] = matrix[row, col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row - 1 >= 0) // up
                        {
                            newMatrix[row - 1, col] = 'B';
                        }
                        if (row + 1 < rows) // down
                        {
                            newMatrix[row + 1, col] = 'B';
                        }
                        if (col - 1 >= 0) // left
                        {
                            newMatrix[row, col - 1] = 'B';
                        }
                        if (col + 1 < cols) // right
                        {
                            newMatrix[row, col + 1] = 'B';
                        }
                    }
                }
            }

            return newMatrix;
        }

        public static void PrintResult(char[,] matrix, int playerRow, int playerCol, string outcome)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine($"{outcome}: {playerRow} {playerCol}");
        }
    }
}
