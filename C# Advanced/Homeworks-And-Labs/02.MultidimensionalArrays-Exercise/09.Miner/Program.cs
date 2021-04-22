using System;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[n, n];

            int minerRow = int.MinValue;
            int minerCol = int.MinValue;
            int coalCounter = 0;
            bool finalPrint = true;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine().Replace(" ", "");

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                        matrix[row, col] = '*';
                    }
                    if (matrix[row, col] == 'c')
                    {
                        coalCounter++;
                    }
                }
            }

            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case "up":
                        if (minerRow - 1 >= 0) minerRow--;
                        break;
                    case "left":
                        if (minerCol - 1 >= 0) minerCol--;
                        break;
                    case "right":
                        if (minerCol + 1 < n) minerCol++;
                        break;
                    case "down":
                        if (minerRow + 1 < n) minerRow++;
                        break;
                }

                if (matrix[minerRow, minerCol] == 'c')
                {
                    coalCounter--;
                    matrix[minerRow, minerCol] = '*';
                    if (coalCounter == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        break;
                    }
                }

                if (matrix[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    finalPrint = false;
                    break;
                }
            }

            if (coalCounter > 0 && finalPrint)
            {
                Console.WriteLine($"{coalCounter} coals left. ({minerRow}, {minerCol})");
            }
        }
    }
}
