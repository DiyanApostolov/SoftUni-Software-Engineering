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
        public string Id { get; init; } = Guid.NewGuid().ToString();

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

        public IEnumerable<UserCard> UserCard { get; init; } = new List<UserCard>();

    }
}
