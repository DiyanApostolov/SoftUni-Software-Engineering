using System;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int marioHealth = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] tower = new char[n, n];
            int marioRow = int.MinValue;
            int marioCol= int.MinValue;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    tower[row, col] = rowData[col];

                    if (tower[row, col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            bool isAlive = true;
            bool isReachPrincess = false;

            while (isAlive && !isReachPrincess)
            {
                char[] input = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();
                char direction = input[0];
                int bowserRow = int.Parse(input[1].ToString());
                int bowserCol = int.Parse(input[2].ToString());
                
                tower[bowserRow, bowserCol] = 'B';
                marioHealth--;
          
                switch (direction)
                {
                    case 'W':
                        if (IsValid(marioRow - 1, marioCol, tower))
                        {
                            if (tower[marioRow - 1, marioCol] == 'B')
                            {
                                marioHealth -= 2;
                                if (marioHealth <= 0)
                                {
                                    isAlive = false;
                                }
                            }
                            else if (tower[marioRow - 1, marioCol] == 'P')
                            {
                                isReachPrincess = true;
                            }

                            tower = MarioMove(direction, marioRow, marioCol, tower);
                            marioRow -= 1;
                        }
                        break;
                    case 'S':
                        if (IsValid(marioRow + 1, marioCol, tower))
                        {
                            if (tower[marioRow + 1, marioCol] == 'B')
                            {
                                marioHealth -= 2;
                                if (marioHealth <= 0)
                                {
                                    isAlive = false;
                                }
                            }
                            else if (tower[marioRow + 1, marioCol] == 'P')
                            {
                                isReachPrincess = true;
                            }

                            tower = MarioMove(direction, marioRow, marioCol, tower);
                            marioRow += 1;
                        }
                        break;
                    case 'A':
                        if (IsValid(marioRow, marioCol - 1, tower))
                        {
                            if (tower[marioRow, marioCol - 1] == 'B')
                            {
                                marioHealth -= 2;
                                if (marioHealth <= 0)
                                {
                                    isAlive = false;
                                }
                            }
                            else if (tower[marioRow, marioCol - 1] == 'P')
                            {
                                isReachPrincess = true;
                            }

                            tower = MarioMove(direction, marioRow, marioCol, tower);
                            marioCol -= 1;
                        }    
                        break;
                    case 'D':
                        if (IsValid(marioRow, marioCol + 1, tower))
                        {
                            if (tower[marioRow, marioCol + 1] == 'B')
                            {
                                marioHealth -= 2;
                                if (marioHealth <= 0)
                                {
                                    isAlive = false;
                                }
                            }
                            else if (tower[marioRow, marioCol + 1] == 'P')
                            {
                                isReachPrincess = true;
                            }

                            tower = MarioMove(direction, marioRow, marioCol, tower);
                            marioCol += 1;
                        }
                        break;
                }
               

                if (isReachPrincess)
                {
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioHealth}");
                    tower[marioRow, marioCol] = '-';
                }
                else if (marioHealth <= 0)
                {
                    isAlive = false;
                    tower[marioRow, marioCol] = 'X';
                    Console.WriteLine($"Mario died at {marioRow - 1};{marioCol}.");
                }

                //Console.WriteLine(marioHealth);
                //PrintMatrix(tower);
                
            }

            PrintMatrix(tower);

        }

        private static char[,] MarioMove(char direction, int marioRow, int marioCol, char[,] tower)
        {
            int row = marioRow;
            int col = marioCol;

            if (direction == 'W')
            {
                if (IsValid(row - 1, col, tower))
                {
                    tower[row, col] = '-';
                    tower[row - 1, col] = 'M';
                }
            }
            else if (direction == 'S')
            {
                if (IsValid(row + 1, col, tower))
                {
                    tower[row, col] = '-';
                    tower[row + 1, col] = 'M';
                }
            }
            else if (direction == 'A')
            {
                if (IsValid(row, col - 1, tower))
                {
                    tower[row, col] = '-';
                    tower[row, col - 1] = 'M';
                }
            }
            else if (direction == 'D')
            {
                if (IsValid(row, col + 1, tower))
                {
                    tower[row, col] = '-';
                    tower[row, col + 1] = 'M';
                }
            }

            return tower;
        }

        private static bool IsValid(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }

        private static void PrintMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
