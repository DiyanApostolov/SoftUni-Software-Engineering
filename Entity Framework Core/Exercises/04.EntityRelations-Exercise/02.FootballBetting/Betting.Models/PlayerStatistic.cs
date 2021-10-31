using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        //TODO
        public int GameId { get; set; }

        public int PlayerId { get; set; }

        public byte ScoredGoals { get; set; }

        public byte Assists { get; set; }

        public byte MinutesPlayed { get; set; }
    }
}
