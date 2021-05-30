using System;
using System.Collections.Generic;

namespace _02.Wharships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            string[] input = Console.ReadLine()
                .Replace(" ", "")
                .Split(',', StringSplitOptions.RemoveEmptyEntries);

            int mineRow = int.MinValue;
            int mineCol = int.MinValue;
            List<string> playerOneShips = new List<string>();
            List<string> playerTwoShips = new List<string>();

            int totalCountShipsDestroyed = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine().Replace(" ", "");

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == '#')
                    {
                        mineRow = row;
                        mineCol = col;
                    }
                    else if (matrix[row, col] == '<')
                    {
                        playerOneShips.Add($"{row}{col}");
                    }
                    else if (matrix[row, col] == '>')
                    {
                        playerTwoShips.Add($"{row}{col}");
                    }
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                string currentCoordinate = input[i];

                if (currentCoordinate.StartsWith('-'))
                {
                    continue;
                }

                int currRow = int.Parse(currentCoordinate[0].ToString());
                int currCol = int.Parse(currentCoordinate[1].ToString());

                if (currRow >= 0 && currRow < n &&
                    currCol >= 0 && currCol < n)
                {
                    if (playerOneShips.Contains(currentCoordinate))
                    {
                        playerOneShips.Remove(currentCoordinate);
                        matrix[currRow, currCol] = 'X';
                        totalCountShipsDestroyed++;
                    }
                    else if (playerTwoShips.Contains(currentCoordinate))
                    {
                        playerTwoShips.Remove(currentCoordinate);
                        matrix[currRow, currCol] = 'X';
                        totalCountShipsDestroyed++;
                    }
                    else if (matrix[currRow, currCol] == '#')
                    {
                        if (currCol - 1 >= 0)
                        {
                            // left up diagonal cell
                            if (currRow - 1 >= 0)
                            {
                                if (matrix[currRow - 1, currCol - 1] == '>')
                                {
                                    playerTwoShips.Remove($"{currRow - 1}{currCol - 1}");
                                    matrix[currRow - 1, currCol - 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                                else if (matrix[currRow - 1, currCol - 1] == '<')
                                {
                                    playerOneShips.Remove($"{currRow - 1}{currCol - 1}");
                                    matrix[currRow - 1, currCol - 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                            }

                            // left cell
                            if (matrix[currRow, currCol - 1] == '>')
                            {
                                playerTwoShips.Remove($"{currRow}{currCol - 1}");
                                matrix[currRow, currCol - 1] = 'X';
                                totalCountShipsDestroyed++;
                            }
                            else if (matrix[currRow, currCol - 1] == '<')
                            {
                                playerOneShips.Remove($"{currRow}{currCol - 1}");
                                matrix[currRow, currCol - 1] = 'X';
                                totalCountShipsDestroyed++;
                            }

                            // left down diagonal cell
                            if (currRow + 1 < n)
                            {
                                if (matrix[currRow + 1, currCol - 1] == '>')
                                {
                                    playerTwoShips.Remove($"{currRow + 1}{currCol - 1}");
                                    matrix[currRow + 1, currCol - 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                                else if (matrix[currRow + 1, currCol - 1] == '<')
                                {
                                    playerOneShips.Remove($"{currRow + 1}{currCol - 1}");
                                    matrix[currRow + 1, currCol - 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                            }
                        }

                            // up cell
                        if (currRow - 1 >= 0)
                        {
                            
                            if (matrix[currRow - 1, currCol] == '>')
                            {
                                playerTwoShips.Remove($"{currRow - 1}{currCol}");
                                matrix[currRow - 1, currCol] = 'X';
                                totalCountShipsDestroyed++;
                            }
                            else if (matrix[currRow - 1, currCol] == '<')
                            {
                                playerOneShips.Remove($"{currRow - 1}{currCol}");
                                matrix[currRow - 1, currCol] = 'X';
                                totalCountShipsDestroyed++;
                            }
                        }

                          // down cell
                        if (currRow + 1 < n)
                        {
                            if (matrix[currRow + 1, currCol] == '>')
                            {
                                playerTwoShips.Remove($"{currRow + 1}{currCol}");
                                matrix[currRow + 1, currCol] = 'X';
                                totalCountShipsDestroyed++;
                            }
                            else if (matrix[currRow + 1, currCol] == '<')
                            {
                                playerOneShips.Remove($"{currRow + 1}{currCol}");
                                matrix[currRow + 1, currCol] = 'X';
                                totalCountShipsDestroyed++;
                            }
                        }

                        if (currCol + 1 < n)
                        {
                            //right up diagonal cell
                            if (currRow - 1 >= 0)
                            {
                                if (matrix[currRow - 1, currCol + 1] == '>')
                                {
                                    playerTwoShips.Remove($"{currRow - 1}{currCol + 1}");
                                    matrix[currRow - 1, currCol + 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                                else if (matrix[currRow - 1, currCol + 1] == '<')
                                {
                                    playerOneShips.Remove($"{currRow - 1}{currCol + 1}");
                                    matrix[currRow - 1, currCol + 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                            }

                            //right cell
                            if (matrix[currRow, currCol + 1] == '>')
                            {
                                playerTwoShips.Remove($"{currRow}{currCol + 1}");
                                matrix[currRow, currCol + 1] = 'X';
                                totalCountShipsDestroyed++;
                            }
                            else if (matrix[currRow, currCol + 1] == '<')
                            {
                                playerOneShips.Remove($"{currRow}{currCol + 1}");
                                matrix[currRow, currCol + 1] = 'X';
                                totalCountShipsDestroyed++;
                            }

                            //right down diagonal cell
                            if (currRow + 1 < n)
                            {
                                if (matrix[currRow + 1, currCol + 1] == '>')
                                {
                                    playerTwoShips.Remove($"{currRow + 1}{currCol + 1}");
                                    matrix[currRow + 1, currCol + 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                                else if (matrix[currRow + 1, currCol + 1] == '<')
                                {
                                    playerOneShips.Remove($"{currRow + 1}{currCol + 1}");
                                    matrix[currRow + 1, currCol + 1] = 'X';
                                    totalCountShipsDestroyed++;
                                }
                            }
                        }

                    }

                    if (playerOneShips.Count <= 0)
                    {
                        Console.WriteLine($"Player Two has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
                        break;
                    }
                    else if (playerTwoShips.Count <= 0)
                    {
                        Console.WriteLine($"Player One has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle.");
                        break;
                    }

                    
                }
            }

            if (playerOneShips.Count > 0 && playerTwoShips.Count > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShips.Count} ships left. Player Two has {playerTwoShips.Count} ships left.");
            }

            //Console.WriteLine();


            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        Console.Write($"{matrix[row, col]} ");
            //    }
            //    Console.WriteLine();
            //}
            
        }
    }
}