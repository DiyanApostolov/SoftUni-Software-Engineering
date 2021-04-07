using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                                    .Split(" ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string elementToRotate = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    string currentElement = array[j];
                    array[j - 1] = currentElement;
                }
                
                array[array.Length - 1] = elementToRotate;
            }
            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
