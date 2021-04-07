using System;

namespace _05.PrintPartOfASCIITable

{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                char ascii = (char) i;
                Console.Write($"{ascii} ");
            }
        }
    }
}
