namespace SMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Cart
    {
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }
            = new List<Product>();
    }
}
