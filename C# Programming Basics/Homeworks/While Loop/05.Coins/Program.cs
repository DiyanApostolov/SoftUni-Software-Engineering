using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double change = Convert.ToInt32(input * 100);
            int coins = 0;
            
            while (change != 0)
            {
                if (change - 200 >= 0)
                {
                    change -= 200;
                    coins++;
                }
                else if (change - 100 >= 0)
                {
                    change -= 100;
                    coins++;
                }
                else if (change - 50 >= 0)
                {
                    change -= 50;
                    coins++;
                }
                else if (change - 20 >= 0)
                {
                    change -= 20;
                    coins++;
                }
                else if (change - 10 >= 0)
                {
                    change -= 10;
                    coins++;
                }
                else if (change - 5 >= 0)

                { 
                    change -= 5;
                    coins++;
                }
                else if (change - 2 >= 0)
                {
                    change -= 2;
                    coins++;
                }
                else if (change - 1 >= 0)
                {
                    change -= 1;
                    coins++;
                }
            }
            
            Console.WriteLine(coins);
        }
    }
}
