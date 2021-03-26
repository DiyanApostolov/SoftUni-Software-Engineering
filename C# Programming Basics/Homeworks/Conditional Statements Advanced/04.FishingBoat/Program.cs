using System;

namespace _04.FishingBoat

{
    class Program
    {
        static void Main(string[] args)
        {                 
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFisherman = int.Parse(Console.ReadLine());

            double rentBoat = 0;

            switch (season)
            {
                case "Spring":
                    rentBoat = 3000;
                    if (numberOfFisherman <= 6)
                    {
                        rentBoat -= rentBoat * 0.1;
                    }
                    else if (numberOfFisherman >=7 && numberOfFisherman <=11)
                    {
                        rentBoat -= rentBoat * 0.15;
                    }
                    else if (numberOfFisherman >= 12)
                    {
                        rentBoat -= rentBoat * 0.25;
                    }

                    if (numberOfFisherman % 2 == 0)
                    {
                        rentBoat -= rentBoat * 0.05;
                    }
                    break;
                case "Summer":
                    rentBoat = 4200;
                    if (numberOfFisherman <= 6)
                    {
                        rentBoat -= rentBoat * 0.1;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rentBoat -= rentBoat * 0.15;
                    }
                    else if (numberOfFisherman >= 12)
                    {
                        rentBoat -= rentBoat * 0.25;
                    }

                    if (numberOfFisherman % 2 == 0)
                    {
                        rentBoat -= rentBoat * 0.05;
                    }
                    break;
                case "Autumn":
                    rentBoat = 4200;
                    if (numberOfFisherman <= 6)
                    {
                        rentBoat -= rentBoat * 0.1;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rentBoat -= rentBoat * 0.15;
                    }
                    else if (numberOfFisherman >= 12)
                    {
                        rentBoat -= rentBoat * 0.25;
                    }
                    break;
                case "Winter":
                    rentBoat = 2600;
                    if (numberOfFisherman <= 6)
                    {
                        rentBoat -= rentBoat * 0.1;
                    }
                    else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                    {
                        rentBoat -= rentBoat * 0.15;
                    }
                    else if (numberOfFisherman >= 12)
                    {
                        rentBoat -= rentBoat * 0.25;
                    }

                    if (numberOfFisherman % 2 == 0)
                    {
                        rentBoat -= rentBoat * 0.05;
                    }
                    break;
            }
            if (budget >= rentBoat)
            {
                double moneyLeft = budget - rentBoat;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = rentBoat - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
