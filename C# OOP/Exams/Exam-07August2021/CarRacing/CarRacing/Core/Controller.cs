namespace CarRacing.Core
{
    using System;
    using System.Linq;
    using System.Text;
    using CarRacing.Core.Contracts;
    using CarRacing.Models.Cars;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Maps;
    using CarRacing.Models.Racers;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Repositories;
    using CarRacing.Utilities.Messages;

    public class Controller : IController
    {
        private CarRepository cars;
        private RacerRepository racers;
        private Map map;

        public Controller()
        {
            cars = new CarRepository();
            racers = new RacerRepository();
            map = new Map();
        }

        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            if (type == "SuperCar")
            {
                SuperCar car = new SuperCar(make, model,VIN, horsePower);

                cars.Add(car);
            }
            else if (type == "TunedCar")
            {
                TunedCar car = new TunedCar(make, model, VIN, horsePower);

                cars.Add(car);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidCarType);
            }

            return string.Format(OutputMessages.SuccessfullyAddedCar, make, model, VIN);
        }

        public string AddRacer(string type, string username, string carVIN)
        {
            ICar car = cars.Models.FirstOrDefault(c => c.VIN == carVIN);

            if (car == null)
            {
                throw new ArgumentException(ExceptionMessages.CarCannotBeFound);
            }
            else if (type == "ProfessionalRacer")
            {
                ProfessionalRacer racer = new ProfessionalRacer(username, car);
                racers.Add(racer);
            }
            else if (type == "StreetRacer")
            {
                StreetRacer racer = new StreetRacer(username, car);
                racers.Add(racer);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidRacerType);
            }

            return string.Format(OutputMessages.SuccessfullyAddedRacer, username);
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            IRacer racerOne = racers.Models.FirstOrDefault(r => r.Username == racerOneUsername);
            IRacer racerTwo = racers.Models.FirstOrDefault(r => r.Username == racerTwoUsername);

            if (racerOne == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RacerCannotBeFound, racerOneUsername));
            }
            else if (racerTwo == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RacerCannotBeFound, racerTwoUsername));
            }

            return map.StartRace(racerOne, racerTwo);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var racer in racers.Models
                .OrderByDescending(r => r.DrivingExperience)
                .ThenBy(r => r.Username))
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
