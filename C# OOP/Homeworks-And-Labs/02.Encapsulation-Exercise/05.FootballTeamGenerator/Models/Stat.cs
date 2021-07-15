namespace _05.FootballTeamGenerator.Models
{
    using System;

    public class Stat
    {
        private const int MinStatsValue = 0;
        private const int MaxStatsValue = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get => this.endurance;
            set
            {
                ValidateStatValue(value, nameof(this.Endurance));
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            set
            {
                ValidateStatValue(value, nameof(this.Sprint));
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            set
            {
                ValidateStatValue(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            set
            {
                ValidateStatValue(value, nameof(this.Passing));
                this.passing = value;
            }
        }

        public int Shooting
        {
            get => this.shooting;
            set
            {
                ValidateStatValue(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }

        public double OverallStat
            => (this.Endurance
            + this.Sprint
            + this.Dribble
            + this.Passing
            + this.Shooting) / 5.0;

        private void ValidateStatValue(int value, string statName)
        {
            if (value < MinStatsValue || value > MaxStatsValue)
            {
                throw new ArgumentException($"{statName} should be between {MinStatsValue} and {MaxStatsValue}.");
            }
        }
    }
}
