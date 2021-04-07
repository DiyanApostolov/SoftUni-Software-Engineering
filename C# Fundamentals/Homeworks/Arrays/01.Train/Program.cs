using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int allPassangers = 0;

            for (int i = 0; i < n; i++)
            {
                int passangers = int.Parse(Console.ReadLine());
                arr[i] = passangers;
                allPassangers += passangers;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine(allPassangers);
        }
    }
}
