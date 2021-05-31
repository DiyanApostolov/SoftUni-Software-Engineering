using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine v12 = new Engine(650, 4200);
            Tire[] tires = new Tire[]
            {
                new Tire(2018, 2.5),
                new Tire(2018, 2.5),
                new Tire(2018, 2.8),
                new Tire(2018, 2.8)
            };

            Car bmw = new Car("BMW", "M5", 2020, 100, 9.5, v12, tires);

            Console.WriteLine($"This car is {bmw.Make} {bmw.Model} with {bmw.Engine.HorsePower} horepower.");

            foreach (var tire in tires)
            {
                Console.WriteLine($"Tire year {tire.Year} with pressure {tire.Pressure}");
            }
        }
    }
}
