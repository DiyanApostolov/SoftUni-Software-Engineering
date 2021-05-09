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

                    if (bakery[row, col] == 'O')
                    {
                        firstPillar[0] = row;
                        firstPillar[1] = col;
                    }

                    if (bakery[row, col] == 'O' && row != firstPillar[0] && col != firstPillar[1])
                    {
                        secondPillar[0] = row;
                        secondPillar[1] = col;
                    }
                }
            }




            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(bakery[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
