namespace _05.FootballTeamGenerator.Models
{
    using System;
    public class Player
    {
        private string name;
        public Player(string name, Stat stat)
        {
            Name = name;
            Stat = stat;
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            } 
        }

        public Stat Stat { get; private set; }

        public double OverallSkillLevel => this.Stat.OverallStat;
    }
}
