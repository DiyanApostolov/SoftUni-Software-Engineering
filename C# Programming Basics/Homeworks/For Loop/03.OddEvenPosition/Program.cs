using System;

namespace _03.OddEvenPosition

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double inputNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += inputNumber;
                    if (evenMax < inputNumber)
                    {
                        evenMax = inputNumber;
                    }
                    if (evenMin > inputNumber)
                    {
                        evenMin = inputNumber;
                    }
                }
                else
                {
                    oddSum += inputNumber;
                    if (oddMax < inputNumber)
                    {
                        oddMax = inputNumber;
                    }
                    if (oddMin > inputNumber)
                    {
                        oddMin = inputNumber;
                    }
                }
            }
            
            Console.WriteLine($"OddSum={oddSum:f2},");
            
            if (oddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
           
            Console.WriteLine($"EvenSum={evenSum:f2},");
            
            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
