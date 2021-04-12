using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            
            
            int numberOfGuests = int.Parse(Console.ReadLine());
            double priceForTicket = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (numberOfGuests >= 10 && numberOfGuests <=15)
            {
                priceForTicket *= 0.85;
            }
            else if (numberOfGuests >15 && numberOfGuests <=20)
            {
                priceForTicket *= 0.8;
            }
            else if (numberOfGuests > 20)
            {
                priceForTicket *= 0.75;
            }
            
            double cakePrice = budget * 0.1;
            double totalPrice = numberOfGuests * priceForTicket + cakePrice;
            
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }
            else if (totalPrice > budget)
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine($"No party! {moneyNeed:f2} leva needed.");
            }
        }
    }
}
