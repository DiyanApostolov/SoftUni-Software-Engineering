using P03_FootballBetting.Data;
using System;

namespace P03_FootballBetting
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            FootballBettingContext data = new FootballBettingContext();

            data.Database.EnsureCreated();

            Console.WriteLine("Db created successfuly!");

            data.Database.EnsureDeleted();
        }
    }
}
