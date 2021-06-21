﻿namespace BattleCards.Data
{
    using BattleCards.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class BattleCardsDbContext : DbContext
    {
        public DbSet<User> Users { get; init; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<UserCard> UserCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BattleCards;Integrated Security=True;");
            }
        }
    }
}
