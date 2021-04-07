using System;

namespace _01.IntegerOperations

{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            double divide = Convert.ToDouble(sum / thirdNumber);
            double multiply = divide * fourthNumber;

            Console.WriteLine(multiply);
        }
    }
}
