namespace BattleCards.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class UserCard
    {

        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public User User { get; set; }

        [Required]
        public string CardId { get; set; }

        public Card Card { get; set; }
    }
}
