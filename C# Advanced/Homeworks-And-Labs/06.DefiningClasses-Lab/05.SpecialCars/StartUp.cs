using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] tiresInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Tire[] currentTires = new Tire[4]
                {
                    new Tire(int.Parse(tiresInfo[0]), double.Parse(tiresInfo[1])),
                    new Tire(int.Parse(tiresInfo[2]), double.Parse(tiresInfo[3])),
                    new Tire(int.Parse(tiresInfo[4]), double.Parse(tiresInfo[5])),
                    new Tire(int.Parse(tiresInfo[6]), double.Parse(tiresInfo[7])),
                };

                tires.Add(currentTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] engineInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(engineInfo[0]);
                double engineCapacity = double.Parse(engineInfo[1]);

                Engine currentEngine = new Engine(horsePower, engineCapacity);

                engines.Add(currentEngine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] carsInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = carsInfo[0];
                string model = carsInfo[1];
                int year = int.Parse(carsInfo[2]);
                double fuelQuantity = double.Parse(carsInfo[3]);
                double fuelConsumption = double.Parse(carsInfo[4]);
                int engineIndex = int.Parse(carsInfo[5]);
                int tiresIndex = int.Parse(carsInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);

                cars.Add(car);

                input = Console.ReadLine();
            }

            Console.WriteLine(GetSpecialCar(cars)); 
        }

        private static string GetSpecialCar(List<Car> cars)
        {
            List<Car> specialCars = cars
                .Where(c => c.Year >= 2017)
                .Where(c => c.Engine.HorsePower > 330)
                .Where(c => c.Tires.Sum(t => t.Pressure) >= 9 && c.Tires.Sum(t => t.Pressure) <= 10)
                .ToList();

            var result = new StringBuilder();

            foreach (var car in specialCars)
            {
                car.Drive(20);
                result.AppendLine($"Make: {car.Make}");
                result.AppendLine($"Model: {car.Model}");
                result.AppendLine($"Year: {car.Year}");
                result.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                result.AppendLine($"FuelQuantity: {car.FuelQuantity}");
            }

            return result.ToString();
        }
    }
}
