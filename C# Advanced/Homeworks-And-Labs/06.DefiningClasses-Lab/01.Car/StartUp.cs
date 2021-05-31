using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Passat 4motion";
            car.Year = 2002;

            Console.WriteLine($"My car is {car.Make} {car.Model} - {car.Year} year.");
        }
    }
}
