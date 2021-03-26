using System;

namespace _04.Histogram

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < 200)
                {
                    p1++;
                }
                else if (inputNumber < 400)
                {
                    p2++;
                }
                else if (inputNumber < 600)
                {
                    p3++;
                }
                else if (inputNumber < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double pp1 = Convert.ToDouble(p1) / n * 100;
            double pp2 = Convert.ToDouble(p2) / n * 100;
            double pp3 = Convert.ToDouble(p3) / n * 100;
            double pp4 = Convert.ToDouble(p4) / n * 100;
            double pp5 = Convert.ToDouble(p5) / n * 100;

            Console.WriteLine($"{pp1:f2}%");
            Console.WriteLine($"{pp2:f2}%");
            Console.WriteLine($"{pp3:f2}%");
            Console.WriteLine($"{pp4:f2}%");
            Console.WriteLine($"{pp5:f2}%");
        }
    }
}
