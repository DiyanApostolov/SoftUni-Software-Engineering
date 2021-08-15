namespace CarRacing.Models.Racers
{
    using System;
    using System.Text;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Utilities.Messages;

    public abstract class Racer : IRacer
    {
        private string username;
        private string racingBehavior;
        private int drivingExperience;
        private ICar car;

        protected Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            this.username = username;
            this.racingBehavior = racingBehavior;
            this.drivingExperience = drivingExperience;
            this.car = car;
        }

        public string Username
        {
            get => this.username;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerName);
                }

                this.username = value;
            }
        }

        public string RacingBehavior
        {
            get => this.racingBehavior;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerBehavior);
                }

                this.racingBehavior = value;
            }
        }

        public int DrivingExperience
        {
            get => this.drivingExperience;
            protected set
            {
                if (this.drivingExperience < 0 || this.drivingExperience > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerDrivingExperience);
                }

                this.drivingExperience = value;
            }
        }

        public ICar Car
        {
            get => this.car;
            private set
            {
                if (this.Car == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerCar);
                }

                this.car = value;
            }
        }

        public bool IsAvailable()
        {
            return this.car.FuelAvailable - this.car.FuelConsumptionPerRace > 0;
        }

        public void Race()
        {
            this.Car.Drive();

            if (GetType().Name == "ProfessionalRacer")
            {
                this.drivingExperience += 10;
            }
            else if (GetType().Name == "StreetRacer")
            {
                this.drivingExperience += 5;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}: {this.username}");
            sb.AppendLine($"--Driving behavior: {this.racingBehavior}");
            sb.AppendLine($"--Driving experience: {this.drivingExperience}");
            sb.AppendLine($"--Car: {this.Car.Make} {this.Car.Model} ({this.Car.VIN})");

            return sb.ToString().TrimEnd();
        }
    }
}
