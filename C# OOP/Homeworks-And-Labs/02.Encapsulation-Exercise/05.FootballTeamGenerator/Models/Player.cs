namespace _05.FootballTeamGenerator.Models
{
    using System;
    public class Player
    {
        public string Name 
        {
            get => this.Name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.Name = value;
            } 
        }

        public Stat Stat { get; private set; }

        public double OverallSkillLevel => this.Stat.OverallStat;
    }
}
