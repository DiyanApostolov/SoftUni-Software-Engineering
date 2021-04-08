using System;
using System.Linq;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());

            PrintResultDivideIntegers(firstInt, secondInt);
        }

        private static void PrintResultDivideIntegers(int firstInt, int secondInt)
        {
            double firstFactorial = firstInt;
            double secondFactorial = secondInt;

            for (int i = firstInt - 1; i > 0; i--)
            {
                firstFactorial *= i;
            }
            
            for (int i = secondInt - 1; i > 0; i--)
            {
                secondFactorial *= i;
            }
            
            double result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:F2}");
        }
    }
}
