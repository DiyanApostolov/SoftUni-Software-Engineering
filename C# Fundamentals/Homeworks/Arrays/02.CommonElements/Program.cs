using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ").ToArray();
            string[] secondArray = Console.ReadLine().Split(" ").ToArray();

            string result = string.Empty;

            for (int i = 0; i < secondArray.Length; i++)
            {
                string currentElement = secondArray[i];

                for (int j = 0; j < firstArray.Length; j++)
                {
                    string secondElement = firstArray[j];

                    if (currentElement == secondElement)
                    {
                        result += currentElement + " ";
                    }
                }
            }

            string[] print = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", print));
        }
    }
}
