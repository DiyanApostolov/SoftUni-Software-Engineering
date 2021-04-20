using System;
using System.Linq;

namespace _05.SnakeMoves
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

            string snake = Console.ReadLine();
            int index = 0;
            string direction = "right";
            int row = 0;
            int col = 0;

            for (int i = 0; i < rows * cols; i++)
            {
                if (direction == "right" && i != 0)
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }

                if (col == cols && direction == "right")
                {
                    col--;
                    row++;
                    direction = "left";
                }

                if (col == -1 && direction == "left")
                {
                    col++;
                    row++;
                    direction = "right";
                }

                matrix[row, col] = snake[index];
                index++;

                if (index == snake.Length)
                {
                    index = 0;
                }

            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
