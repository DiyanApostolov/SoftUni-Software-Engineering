using System;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());

            double dayWins = 0; 
            double dayLoses = 0;
            double totalMoney = 0;

            for (int i = 1; i <= numberOfDays; i++)
            {
                double wins = 0;
                double loses = 0;
                double moneyPerDay = 0;               

                string sport = Console.ReadLine();
                
                while (sport != "Finish")
                {
                    string winOrLose = Console.ReadLine();
                    if (winOrLose == "win")
                    {
                        wins++;
                        moneyPerDay += 20;
                    }
                    else
                    {
                        loses++;
                    }
                    sport = Console.ReadLine();
                }
                
                if (wins > loses)
                {
                    dayWins++;
                    moneyPerDay += moneyPerDay * 0.1;
                }
                else
                {
                    dayLoses++;
                }
                
                totalMoney += moneyPerDay;
            }
            
            if (dayWins > dayLoses)
            {
                totalMoney += totalMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:F2}");
            }
        }
    }
}
