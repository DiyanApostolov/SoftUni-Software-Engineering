namespace SMS.Data
{
    using Microsoft.EntityFrameworkCore;
    using SMS.Models;

    // ReSharper disable once InconsistentNaming
    public class SMSDbContext : DbContext
    {
        public SMSDbContext()
        {
            
        }

        public DbSet<User> Users { get; init; }

        public DbSet<Product> Products { get; init; }

        public DbSet<Cart> Carts { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=SMS;Trusted_Connection=True;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasOne<User>(a => a.User)
                .WithOne(b => b.Cart)
                .HasForeignKey<User>(e => e.CartId);

            modelBuilder.Entity<Product>()
                .HasOne<Cart>(s => s.Cart)
                .WithMany(g => g.Products)
                .HasForeignKey(s => s.CartId);
        }
    }
}