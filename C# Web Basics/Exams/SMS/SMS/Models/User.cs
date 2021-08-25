namespace SMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class User
    {
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string CartId { get; set; }

        [Required]
        public Cart Cart { get; set; }
    }
}
