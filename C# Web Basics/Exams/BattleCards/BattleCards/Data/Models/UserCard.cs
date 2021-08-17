using System.ComponentModel.DataAnnotations;

namespace BattleCards.Data.Models
{
    public class UserCard
    {
        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int CardId { get; set; }

        public Card Card { get; set; }
    }
}
