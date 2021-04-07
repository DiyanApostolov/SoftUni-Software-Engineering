using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int firstNumber = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secondNumber = arr[j];
                    
                    if (sum == firstNumber + secondNumber)
                    {
                        Console.Write($"{firstNumber} {secondNumber}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
