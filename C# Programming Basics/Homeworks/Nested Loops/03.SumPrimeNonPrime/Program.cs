using System;

namespace _03.SumPrimeNonPrime

{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrimeNumbers = 0;
            int sumNonprimeNumbers = 0;

            int prime = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                prime = 0;

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                if (number == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 1; i <= number; i++)
                {                 
                    if (number % i == 0)
                    {
                        prime++;
                    }
                }
                
                if (prime == 2)
                {
                    sumPrimeNumbers += number;
                }
                else
                {
                    sumNonprimeNumbers += number;
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonprimeNumbers}");
        }
    }
}
