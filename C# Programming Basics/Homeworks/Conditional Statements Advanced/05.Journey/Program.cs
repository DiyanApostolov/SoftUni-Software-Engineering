using System;

namespace _05.Journey

{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double money = 0;
            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        money = budget * 0.3;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {money:f2}");
                        break;
                    case "winter":
                        money = budget * 0.7;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {money:f2}");
                        break;
                }            
            }
            else if (budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        money = budget * 0.4;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Camp - {money:f2}");
                        break;
                    case "winter":
                        money = budget * 0.8;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {money:f2}");
                        break;
                }
            }
            else
            {
                money = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {money:f2}");               
            }
        }
    }
}
