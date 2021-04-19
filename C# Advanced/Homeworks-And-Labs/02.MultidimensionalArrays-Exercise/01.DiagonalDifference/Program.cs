using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;
            int index = n - 1;

            for (int row = 0; row < n; row++)
            {
                sumFirstDiagonal += matrix[row, row];
                sumSecondDiagonal += matrix[row, index];
                index--;
            }

            int abosuleteDiference = Math.Abs(sumFirstDiagonal - sumSecondDiagonal);
            Console.WriteLine(abosuleteDiference);
        }
    }
}
