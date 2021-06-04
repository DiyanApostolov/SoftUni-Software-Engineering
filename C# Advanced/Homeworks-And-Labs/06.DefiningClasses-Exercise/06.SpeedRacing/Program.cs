using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);

                Car currentCar = new Car
                {
                    Model = carModel,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionFor1km
                };

                cars.Add(currentCar);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] driveArgument = input.Split();
                if (driveArgument[0] == "Drive")
                {
                    string carModel = driveArgument[1];
                    double amountOfKm = double.Parse(driveArgument[2]);

                    var car = cars
                        .Where(x => x.Model == carModel)
                        .FirstOrDefault();

                    car.Drive(amountOfKm);
                }
               
                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
