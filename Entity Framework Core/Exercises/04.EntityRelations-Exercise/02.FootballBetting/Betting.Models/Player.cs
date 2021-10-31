using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        public byte SquadNumber { get; set; }

        //TODO
        public int TeamId { get; set; }

        public int PositionId { get; set; }

        public bool IsInjured { get; set; }
    }
}
