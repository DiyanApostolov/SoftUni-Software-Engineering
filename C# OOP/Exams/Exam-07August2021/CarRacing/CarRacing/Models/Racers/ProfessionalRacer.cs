namespace CarRacing.Models.Racers
{
    using CarRacing.Models.Cars.Contracts;

    public class ProfessionalRacer : Racer
    {
        private const string racingBehavior = "strict";
        private const int drivingExperience = 30;

        public ProfessionalRacer(string username, ICar car) 
            : base(username, racingBehavior, drivingExperience, car)
        {
        }
    }
}
