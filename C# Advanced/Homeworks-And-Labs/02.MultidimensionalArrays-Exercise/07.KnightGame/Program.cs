using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int removedKnights = 0;

            while (true)
            {
                int knightRow = int.MinValue;
                int knightCol = int.MinValue;
                int totalAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int tempAttacks = CountAttack(matrix, row, col);

                            if (tempAttacks > totalAttacks)
                            {
                                totalAttacks = tempAttacks;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }

                if (totalAttacks > 0)
                {
                    matrix[knightRow, knightCol] = '0';
                    removedKnights++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedKnights);
        }

        private static int CountAttack(char[,] matrix, int row, int col)
        {
            int attacks = 0;

            if (IsValid(row - 2, col + 1, matrix))
            {
                attacks++;
            }
            if (IsValid(row - 2, col - 1, matrix))
            {
                attacks++;
            }
            if (IsValid(row - 1, col - 2, matrix))
            {
                attacks++;
            }
            if (IsValid(row + 1, col - 2, matrix))
            {
                attacks++;
            }
            if (IsValid(row + 2, col - 1, matrix))
            {
                attacks++;
            }
            if (IsValid(row + 2, col + 1, matrix))
            {
                attacks++;
            }
            if (IsValid(row - 1, col + 2, matrix))
            {
                attacks++;
            }
            if (IsValid(row + 1, col + 2, matrix))
            {
                attacks++;
            }

            return attacks;
        }

        private static bool IsValid(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1)
                && matrix[row, col] == 'K';
        }
    }
}
