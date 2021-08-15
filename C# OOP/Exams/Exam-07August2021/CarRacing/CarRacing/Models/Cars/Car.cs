namespace CarRacing.Models.Cars
{
    using System;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Utilities.Messages;

    public abstract class Car : ICar
    {
        private string make;
        private string model;
        private string vIN;
        private int horsePower;
        private double fuelConsumptionPerRace;

        protected Car(string make, string model, string vIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = vIN;
            this.HorsePower = horsePower;
            this.FuelAvailable = fuelAvailable;
            this.FuelConsumptionPerRace = fuelConsumptionPerRace;
        }

        public string Make
        {
            get => this.make;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarMake);
                }

                this.make = value;
            }
        }

        public string Model
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarModel);
                }

                this.model = value;
            }
        }

        public string VIN
        {
            get => this.vIN;
            private set
            {
                if (value.Length != 17)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarVIN);
                }

                this.vIN = value;
            }
        }

        public int HorsePower
        {
            get => this.horsePower;
            protected set
            {
                if (this.horsePower < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarHorsePower);
                }

                this.horsePower = value;
            }
        }

        public double FuelAvailable { get; private set; }

        public double FuelConsumptionPerRace
        {
            get => this.fuelConsumptionPerRace;
            private set
            {
                if (this.horsePower < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarFuelConsumption);
                }

                this.fuelConsumptionPerRace = value;
            }
        }

        public void Drive()
        {
            this.FuelAvailable -= this.fuelConsumptionPerRace;

            if (this.FuelAvailable < 0)
            {
                this.FuelAvailable = 0;
            }

            if (GetType().Name == "TunedCar")
            {
                this.horsePower = (int)Math.Round(this.horsePower * 0.97);
            }
        }
    }
}
