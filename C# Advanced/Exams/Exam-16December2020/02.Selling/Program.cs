using System;

namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] bakery = new char[n,n];
            int[] myPosition = new int[2];
            int[] firstPillar = new int[2];
            int[] secondPillar = new int[2];
            int counter = 1;
            int money = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    bakery[row, col] = rowData[col];

                    if (bakery[row, col] == 'S')
                    {
                        myPosition[0] = row;
                        myPosition[1] = col;
                    }

                    if (bakery[row, col] == 'O' && counter == 1)
                    {
                        firstPillar[0] = row;
                        firstPillar[1] = col;
                        counter++;
                    }

                    if (bakery[row, col] == 'O' && counter == 2)
                    {
                        secondPillar[0] = row;
                        secondPillar[1] = col;
                    }
                }
            }

            while (IsInBakery(myPosition, n))
            {
                string direction = Console.ReadLine();
                bakery[myPosition[0], myPosition[1]] = '-';

                switch (direction)
                {
                    case ("left"): myPosition[1]--; break;
                    case ("right"): myPosition[1]++; break;
                    case ("up"): myPosition[0]--; break;
                    case ("down"): myPosition[0]++; break;
                }

                if (IsInBakery(myPosition, n))
                {
                    char currentChar = bakery[myPosition[0], myPosition[1]];
                    if (currentChar == 'O')
                    {
                        bakery[firstPillar[0], firstPillar[1]] = '-';
                        myPosition[0] = secondPillar[0];
                        myPosition[1] = secondPillar[1];
                        bakery[myPosition[0], myPosition[1]] = 'S';
                    }
                    else if (Char.IsDigit(currentChar))
                    {
                        money += int.Parse(currentChar.ToString());
                        bakery[myPosition[0], myPosition[1]] = 'S';
                    }
                }
                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                }

                if (money >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }
            }

            Console.WriteLine($"Money: {money}");

            PrintMatrix(bakery);
        }

        private static void PrintMatrix(char[,] bakery)
        {
            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                for (int col = 0; col < bakery.GetLength(1); col++)
                {
                    Console.Write(bakery[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInBakery(int[] myPosition, int n)
        {
            if (myPosition[0] < n && myPosition[0] >= 0 && myPosition[1] < n && myPosition[1] >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
