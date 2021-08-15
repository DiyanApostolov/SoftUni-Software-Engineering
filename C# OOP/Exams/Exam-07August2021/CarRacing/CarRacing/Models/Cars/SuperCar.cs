namespace CarRacing.Models.Cars
{
    public class SuperCar : Car
    {
        private const double fuelAvailable = 80;
        private const double fuelConsumptionPerRace = 10;

        public SuperCar(string make, string model, string vIN, int horsePower) 
            : base(make, model, vIN, horsePower, fuelAvailable, fuelConsumptionPerRace)
        {
        }
    }
}
