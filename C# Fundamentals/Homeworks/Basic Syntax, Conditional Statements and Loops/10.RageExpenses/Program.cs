using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0;
            int keyboardCounter = 0;
            
            for (int i = 1; i <= numberOfLostGames; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                
                if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }
                
                if (i % 2 == 0 && i % 3 == 0)
                {
                    expenses += keyboardPrice;
                    keyboardCounter++;
                    
                    if (keyboardCounter % 2 == 0)
                    {
                        expenses += displayPrice;
                    }
                }
            }
            
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
