using System;

namespace _07.HotelRoom

{
    class Program
    {
        static void Main(string[] args)
        {
            double studioMayOctober = 50;
            double studioJuneSeptember = 75.2;
            double studioJulyAugust = 76;
            double apartmentMayOctober = 65;
            double apartmentJuneSeptember = 68.7;
            double apartmentJulyAugust = 77;

            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double totalPriceStudio = 0;
            double totalPriceApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    totalPriceStudio = nights * studioMayOctober;
                    totalPriceApartment = nights * apartmentMayOctober;
                    if (nights > 7 && nights <14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.05;                      
                    }
                    else if (nights > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.3;                       
                    }                                      
                    break;
                case "June":
                case "September":
                    totalPriceStudio = nights * studioJuneSeptember;
                    totalPriceApartment = nights * apartmentJuneSeptember;
                    if (nights > 14)
                    {                   
                        totalPriceStudio -= totalPriceStudio * 0.2;                       
                    }
                   
                    break;
                case "July":
                case "August":
                    totalPriceStudio = nights * studioJulyAugust;
                    totalPriceApartment = nights * apartmentJulyAugust;                   
                    break;              
            }
            
            if (nights > 14)
            {
                totalPriceApartment -= totalPriceApartment * 0.1;
            }
            
            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}
