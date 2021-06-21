namespace BattleCards.Data
{
    using Microsoft.EntityFrameworkCore;

    public class BattleCardsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BattleCards;Integrated Security=True;");
            }
        }
    }
}
