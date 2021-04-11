using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {          
            List<Vehicle> vehicles = new List<Vehicle>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] input = command.Split();
                string type = input[0].ToLower();
                string model = input[1];
                string color = input[2];
                int horsepower = int.Parse(input[3]);

                Vehicle newVehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(newVehicle);

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();           
            while (secondCommand != "Close the Catalogue")  
            {
                string modelType = secondCommand;
                Vehicle currentVehicle = vehicles.First(x => x.Model == modelType);
                Console.WriteLine(currentVehicle);

                secondCommand = Console.ReadLine();
            }

            List<Vehicle> onlyCars = vehicles.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = vehicles.Where(x => x.Type == "truck").ToList();

            double totalCarHp = onlyCars.Sum(x => x.Horsepower);
            double totalTruckHp = onlyTrucks.Sum(x => x.Horsepower);
            double averageCarHp = 0.00;
            double averageTruckHp = 0.00;

            if (onlyCars.Count > 0)
            {
                averageCarHp = totalCarHp / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                averageTruckHp = totalTruckHp / onlyTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:F2}.");
        }

        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsepower)
            {
                Type = type;
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
                sb.AppendLine($"Model: {Model}");
                sb.AppendLine($"Color: {Color}");
                sb.AppendLine($"Horsepower: {Horsepower}");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
