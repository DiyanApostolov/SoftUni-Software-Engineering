namespace _06.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; } = 0;

        public void Drive(double amountOfKm)
        {
            if (amountOfKm * this.FuelConsumptionPerKilometer <= this.FuelAmount)
            {
                this.TravelledDistance += amountOfKm;
                this.FuelAmount -= (amountOfKm * this.FuelConsumptionPerKilometer);
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance}";
        }
    }
}
