using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gardenDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = gardenDimensions[0];
            int col = gardenDimensions[1];

            int[,] garden = new int[row, col];
            List<int[]> flowerPosition = new List<int[]>();

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                int[] currentCoordinates = input
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int currRow = currentCoordinates[0];
                int currCol = currentCoordinates[1];

                if (currRow >= 0 && currRow < row && currCol >= 0 && currCol < col)
                {
                    flowerPosition.Add(new int[2] {currRow, currCol});
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < flowerPosition.Count; i++)
            {
                int currRow = flowerPosition[i][0];
                int currCol = flowerPosition[i][1];

                garden[currRow, currCol]++;

                Bloom(garden, currRow, currCol);
            }

            PrintMatrix(garden);
        }

        
        private static void Bloom(int[,] garden, int currRow, int currCol)
        {
            // direction of bloom - up
            for (int i = currRow + 1; i < garden.GetLength(0); i++)
            {
                garden[i, currCol]++;
            }

            // direction of bloom - right
            for (int i = currCol + 1; i < garden.GetLength(1); i++)
            {
                garden[currRow, i]++;
            }

            // direction of bloom - down
            for (int i = currRow - 1; i >= 0; i--)
            {
                garden[i, currCol]++;
            }

            // direction of bloom - left
            for (int i = currCol - 1; i >= 0; i--)
            {
                garden[currRow, i]++;
            }
        }

        private static void PrintMatrix(int[,] garden)
        {
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
