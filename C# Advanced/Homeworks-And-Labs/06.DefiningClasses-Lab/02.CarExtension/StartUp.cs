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
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(0.5);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
