namespace SMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class Product
    {
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(DefaultMaxLength)]
        public string Name { get; set; }

        [Range(PriceMinRange, PriceMaxRange)]
        public decimal Price { get; set; }

        public Cart Cart { get; set; }

        public string CartId { get; set; }
    }
}
