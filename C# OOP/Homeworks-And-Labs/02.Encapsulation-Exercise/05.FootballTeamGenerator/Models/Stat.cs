namespace _05.FootballTeamGenerator.Models
{
    using System;

    public class Stat
    {
        private const int MinStatsValue = 0;
        private const int MaxStatsValue = 100;

        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribblе = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get => this.Endurance;
            set
            {
                ValidateStatValue(value, nameof(this.Endurance));
                this.Endurance = value;
            }
        }

        public int Sprint
        {
            get => this.Sprint;
            set
            {
                ValidateStatValue(value, nameof(this.Sprint));
                this.Sprint = value;
            }
        }

        public int Dribblе
        {
            get => this.Dribblе;
            set
            {
                ValidateStatValue(value, nameof(this.Dribblе));
                this.Dribblе = value;
            }
        }

        public int Passing
        {
            get => this.Passing;
            set
            {
                ValidateStatValue(value, nameof(this.Passing));
                this.Passing = value;
            }
        }

        public int Shooting
        {
            get => this.Shooting;
            set
            {
                ValidateStatValue(value, nameof(this.Shooting));
                this.Shooting = value;
            }
        }

        public double OverallStat
            => (this.Endurance
            + this.Sprint
            + this.Dribblе
            + this.Passing
            + this.Shooting) / 5.0;

        private void ValidateStatValue(double value, string statName)
        {
            if (value < MinStatsValue || value > MaxStatsValue)
            {
                throw new ArgumentException($"{statName} should be between {MinStatsValue} and {MaxStatsValue}.");
            }
        }
    }
}
