using System;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string datesOfTrip = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double priceForNight = 0;

            switch (destination)
            {
                case "France":
                    switch (datesOfTrip)
                    {
                        case "21-23":
                            priceForNight = 30;
                            break;
                        case "24-27":
                            priceForNight = 35;
                            break;
                        case "28-31":
                            priceForNight = 40;
                            break;
                    }
                    break;
                case "Italy":
                    switch (datesOfTrip)
                    {
                        case "21-23":
                            priceForNight = 28;
                            break;
                        case "24-27":
                            priceForNight = 32;
                            break;
                        case "28-31":
                            priceForNight = 39;
                            break;
                    }
                    break;
                case "Germany":
                    switch (datesOfTrip)
                    {
                        case "21-23":
                            priceForNight = 32;
                            break;
                        case "24-27":
                            priceForNight = 37;
                            break;
                        case "28-31":
                            priceForNight = 43;
                            break;
                    }
                    break;
            }

            double finalPrice = numberOfNights * priceForNight;
            Console.WriteLine($"Easter trip to {destination} : {finalPrice:f2} leva.");        
        }
    }
}
