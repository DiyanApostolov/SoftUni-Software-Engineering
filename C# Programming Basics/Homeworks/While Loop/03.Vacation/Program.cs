using System;

namespace _03.Vacation

{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double moneyInPocket = double.Parse(Console.ReadLine());

            double savedMoney = moneyInPocket;
            int days = 0;
            int spendingCounter = 0;

            while (savedMoney < moneyForTrip)
            {
                string input = Console.ReadLine();
                double spendSavedMoney = double.Parse(Console.ReadLine());
                days++;

                if (input == "save")
                {
                    savedMoney += spendSavedMoney;
                    spendingCounter = 0;
                }
                else
                {
                    savedMoney -= spendSavedMoney;
                    spendingCounter++;
                    if (savedMoney < 0)
                    {
                        savedMoney = 0;
                    }
                    if (spendingCounter == 5)
                    {
                        break;
                    }

                }
            }
            
            if (spendingCounter == 5 || moneyForTrip > savedMoney)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
            
            if (savedMoney >= moneyForTrip)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }            
        }
    }
}
