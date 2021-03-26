using System;

namespace _05.DivideWithoutRemainder

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber % 2 == 0)
                {
                    p1++;
                }
                if (inputNumber % 3 == 0)
                {
                    p2++;
                }
                if (inputNumber % 4 == 0)
                {
                    p3++;
                }
            }

            double pp1 = Convert.ToDouble(p1) / n * 100;
            double pp2 = Convert.ToDouble(p2) / n * 100;
            double pp3 = Convert.ToDouble(p3) / n * 100;

            Console.WriteLine($"{pp1:f2}%");
            Console.WriteLine($"{pp2:f2}%");
            Console.WriteLine($"{pp3:f2}%");
        }
    }
}
