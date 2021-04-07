using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            bool isBigger = true;

            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentElement <= array[j])
                    {
                        isBigger = false;
                        break;
                    }
                }
                
                if (isBigger)
                {
                    Console.Write(currentElement + " ");
                }
                
                isBigger = true;
            }
        }
    }
}
