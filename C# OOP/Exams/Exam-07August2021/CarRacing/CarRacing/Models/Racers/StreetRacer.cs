namespace CarRacing.Models.Racers
{
    using CarRacing.Models.Cars.Contracts;

    public class StreetRacer : Racer
    {
        private const string racingBehavior = "aggressive";
        private const int drivingExperience = 10;

        public StreetRacer(string username, ICar car) 
            : base(username, racingBehavior, drivingExperience, car)
        {
        }
    }
}
