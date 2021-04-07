using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            bool isEqual = false;

            for (int curr = 0; curr < array.Length; curr++)
            {
                int rightSum = 0;

                for (int i = curr + 1; i < array.Length; i++)
                {
                    rightSum += array[i];
                }

                int leftSum = 0;

                for (int i = curr - 1; i >= 0; i--)
                {
                    leftSum += array[i];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(curr);
                    isEqual = true;
                    break;
                }                            
            }

            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
