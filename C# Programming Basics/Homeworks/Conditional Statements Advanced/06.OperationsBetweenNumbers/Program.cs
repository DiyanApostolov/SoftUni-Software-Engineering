using System;

namespace _06.OperationsBetweenNumbers

{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;
            if (symbol == '+')
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == '-')
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == '*')
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - odd");
                }
            }
            else if (symbol == '/')
            {
                result = n1 / n2;
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result}");
                }
            }
            else if (symbol == '%')
            {
                result = n1 % n2;
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    Console.WriteLine($"{n1} {symbol} {n2} = {result}");
                }
            }
        }
    }
}
