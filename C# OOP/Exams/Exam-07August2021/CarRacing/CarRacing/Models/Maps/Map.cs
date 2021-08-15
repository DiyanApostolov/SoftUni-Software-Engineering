namespace CarRacing.Models.Maps
{
    using System;
    using CarRacing.Models.Maps.Contracts;
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Utilities.Messages;

    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            string winner;

            if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return string.Format(OutputMessages.RaceCannotBeCompleted);
            }

            if (!racerOne.IsAvailable())
            {
                winner = racerTwo.Username;
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerTwo.Username, racerOne.Username);
            }
            else if (!racerTwo.IsAvailable())
            {
                winner = racerOne.Username;
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerOne.Username, racerTwo.Username);
            }

            double racingOneBehaviorMultiplier = racerOne.RacingBehavior == "strict" ? 1.2 : 1.1;
            double racerOnepoints = racerOne.Car.HorsePower * racerOne.DrivingExperience * racingOneBehaviorMultiplier;
            double racingTwoBehaviorMultiplier = racerTwo.RacingBehavior == "strict" ? 1.2 : 1.1;
            double racerTwopoints = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racingTwoBehaviorMultiplier;

            racerOne.Race();
            racerTwo.Race();

            winner = racerOnepoints > racerTwopoints ? racerOne.Username : racerTwo.Username; 

            return string.Format(OutputMessages.RacerWinsRace, racerOne.Username, racerTwo.Username, winner);
        }
    }
}
