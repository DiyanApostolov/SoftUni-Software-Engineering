namespace BattleCards.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    public class UserCard
    {
        [Key]
        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int CardId { get; set; }

        public Card Card { get; set; }
    }
}
