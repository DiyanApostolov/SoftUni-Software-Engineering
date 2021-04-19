using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            char symbol = Convert.ToChar(Console.ReadLine());
            string ouput = string.Empty;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        ouput = $"({row}, {col})";
                        break;
                    };
                }

                if (ouput != string.Empty)
                {
                    break;
                }
            }

            if (ouput != string.Empty)
            {
                Console.WriteLine(ouput);
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
    }
}
