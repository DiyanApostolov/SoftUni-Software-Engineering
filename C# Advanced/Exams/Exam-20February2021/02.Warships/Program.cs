using System;
using System.Linq;

namespace _02.Wharships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            string[] input = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries);

            int playerOneShips = 0;
            int playerTwoShips = 0;
            int totalCountShipsDestroyed = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == '<')
                    {
                        playerOneShips++;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        playerTwoShips++;
                    }
                }
            }

            bool isSomeoneWon = false;

            for (int i = 0; i < input.Length; i++)
            {
                int[] currentCoordinate = input[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currRow = currentCoordinate[0];
                int currCol = currentCoordinate[1];

                if (currRow < 0 || currRow >= n || currCol < 0 || currCol >= n)
                {
                    continue;
                }

                if (IsPlayerOneShip(matrix, currRow, currCol))
                {
                    playerOneShips--;
                    matrix[currRow, currCol] = 'X';
                    totalCountShipsDestroyed++;
                }
                else if (IsPlayerTwoShip(matrix, currRow, currCol))
                {
                    playerTwoShips--;
                    matrix[currRow, currCol] = 'X';
                    totalCountShipsDestroyed++;
                }
                else if (matrix[currRow, currCol] == '#')
                {
                    for (int row = currRow - 1; row <= currRow + 1; row++)
                    {
                        for (int col = currCol - 1; col <= currCol + 1; col++)
                        {
                            if (row >= 0 && row < n &&
                                col >= 0 && col < n)
                            {
                                if (IsPlayerOneShip(matrix, row, col))
                                {
                                    playerOneShips--;
                                    matrix[row, col] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                                else if (IsPlayerTwoShip(matrix, row, col))
                                {
                                    playerTwoShips--;
                                    matrix[row, col] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                            }

                            if (playerOneShips == 0)
                            {
                                isSomeoneWon = true;
                                break;
                            }
                            else if (playerTwoShips == 0)
                            {
                                isSomeoneWon = true;
                                break;
                            }
                        }

                        if (isSomeoneWon)
                        {
                            break;
                        }
                    }
                }

                

                if (playerOneShips <= 0)
                {
                    Console.WriteLine($"Player Two has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
                    break;
                }
                else if (playerTwoShips <= 0)
                {
                    Console.WriteLine($"Player One has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
                    break;
                }
            }

            if (playerOneShips > 0 && playerTwoShips > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips} ships left. Player Two has {playerTwoShips} ships left.");
            }
        }

        public static bool IsPlayerOneShip(char[,] field, int row, int col)
        {
            return field[row, col] == '<';
        }

        public static bool IsPlayerTwoShip(char[,] field, int row, int col)
        {
            return field[row, col] == '>';
        }
    }
}