namespace BattleCards.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;
    public class Card
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public int Id { get; set; } 

        [Required]
        [MaxLength(MaxCardName)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Keyword { get; set; }

        [Required]
        public int Attack { get; set; }

        [Required]
        public int Health { get; set; }

        [Required]
        [MaxLength(MaxCardDescription)]
        public string Description { get; set; }

        public ICollection<UserCard> Users { get; set; } 
            = new List<UserCard>();

    }
}
