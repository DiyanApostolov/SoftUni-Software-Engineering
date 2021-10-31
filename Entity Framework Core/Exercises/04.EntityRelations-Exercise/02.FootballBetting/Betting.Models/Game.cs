using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Game
    {
        public int HomeTeamId { get; set; }

        public int AwayTeamId { get; set; }

        public byte HomeTeamGoals { get; set; }

        public byte AwayTeamGoals { get; set; }

        public DateTime DateTime { get; set; }

        public double HomeTeamBetRate { get; set; }

        public double AwayTeamBetRate { get; set; }

        public double DrawBetRate { get; set; }

        [MaxLength(6)]
        public string Result { get; set; }
    }
}
