using System;

namespace _06.Cake

{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cake = width * lenght;
            int peaces = 0;
            
            while (cake > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                peaces = Convert.ToInt32(input);
                cake -= peaces;
                if (cake <= 0)
                {
                    break;
                }

            }
            
            if (cake >= 0)
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
