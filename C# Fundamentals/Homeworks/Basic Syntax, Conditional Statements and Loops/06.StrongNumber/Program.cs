using System;

namespace _06.StrongNumber

{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;

            int currentNumber = 0;
            int factorielSum = 0;

            while (number != 0)
            {
                currentNumber = number % 10;
                number /= 10;
                int factorial = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }
                factorielSum += factorial;
            }

            string result = "";
            
            if (factorielSum == input)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }
            
            Console.WriteLine(result);
        }
    }
}
