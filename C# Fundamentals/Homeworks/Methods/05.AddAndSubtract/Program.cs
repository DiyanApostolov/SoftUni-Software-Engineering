using System;
using System.Linq;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int result = Sum(firstInt, secondInt);
            Subtract(thirdInt, result);
        }     

        private static int Sum(int firstInt, int secondInt)
        {
            int sum = firstInt + secondInt;

            return sum;
        }
        
        private static void Subtract(int thirdInt, int result)
        {
            int subtract = result - thirdInt;

            Console.WriteLine(subtract);
        }
    }
}
