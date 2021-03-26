using System;

namespace _01.Cinema

{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0;

            if (type == "Premiere")
            {
                income = rows * colums * 12;
            }
            else if (type == "Normal")
            {
                income = rows * colums * 7.5;
            }
            else if (type == "Discount")
            {
                income = rows * colums * 5;
            }
            
            // Output
            Console.WriteLine($"{income:f2}");
        }
    }
}
