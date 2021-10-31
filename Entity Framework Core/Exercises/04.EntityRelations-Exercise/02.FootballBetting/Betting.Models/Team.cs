using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        [MaxLength(4)]
        public string Initials { get; set; }

        public decimal Budget { get; set; }

        //TODO
        public int PrimaryKitColorId { get; set; }

        public int SecondaryKitColorId { get; set; }

        public int TownId { get; set; }
    }
}
