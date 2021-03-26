using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            
            // Calculations
            if (inputUnit == "mm" && outputUnit == "m")
            {
                number /= 1000;
            }
            else if (inputUnit == "m" && outputUnit == "mm")
            {
                number *= 1000;
            }
            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                number /= 10;
            }
            else if (inputUnit == "cm" && outputUnit == "mm")
            {
                number *= 10;
            }
            else if (inputUnit == "cm" && outputUnit == "m")
            {
                number /= 100;
            }
            else if (inputUnit == "m" && outputUnit == "cm")
            { 
                number *= 100;
            }
            
            //Output
            Console.WriteLine($"{number:f3}");
        }
    }
}
