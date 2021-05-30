using System;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int marioHealth = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[][] tower = new char[n][];
            int marioRow = int.MinValue;
            int marioCol = int.MinValue;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                tower[row] = new char[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    tower[row][col] = rowData[col];

                    if (tower[row][col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            bool isReachPrincess = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                char direction = char.Parse(input[0]);
                int bowserRow = int.Parse(input[1]);
                int bowserCol = int.Parse(input[2]);

                tower[bowserRow][bowserCol] = 'B';
                marioHealth--;

                switch (direction)
                {
                    case 'W':

                        if (marioRow - 1 < 0)
                        {
                            continue;
                        }

                        tower[marioRow][marioCol] = '-';
                        marioRow--;
                        break;
                    case 'S':

                        if (marioRow + 1 >= n)
                        {
                            continue;
                        }

                        tower[marioRow][marioCol] = '-';
                        marioRow++;
                        break;
                    case 'A':

                        if (marioCol - 1 < 0)
                        {
                            continue;
                        }

                        tower[marioRow][marioCol] = '-';
                        marioCol--;  
                        break;
                    case 'D':

                        if (marioCol + 1 >= tower[0].Length)
                        {
                            continue;
                        }

                        tower[marioRow][marioCol] = '-';
                        marioCol++;
                        break;
                }

                if (tower[marioRow][marioCol] == 'B')
                {
                    marioHealth -= 2;
                    if (marioHealth <= 0)
                    {
                        tower[marioRow][marioCol] = 'X';
                        break;
                    }
                }
                else if (tower[marioRow][marioCol] == 'P')
                {
                    isReachPrincess = true;
                    tower[marioRow][marioCol] = '-';
                    break;
                }

                if (marioHealth <= 0)
                {
                    tower[marioRow][marioCol] = 'X';
                    break;
                }

                tower[marioRow][marioCol] = 'M';
            }

            if (isReachPrincess)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioHealth}");
            }
            else 
            {
                Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
            }

            PrintMatrix(tower);
        }

        private static void PrintMatrix(char[][] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
