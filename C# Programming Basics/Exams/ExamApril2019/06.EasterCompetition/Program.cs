using System;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBreads = int.Parse(Console.ReadLine());
                       
            int poinstsValue = int.MinValue;
            string winnerName = "";

            for (int i = 1; i <= numberOfBreads; i++)
            {
                int pointsOfCooker = 0;
                string nameOfCooker = Console.ReadLine();
                string points = Console.ReadLine();
                while (points != "Stop")
                {
                    pointsOfCooker += int.Parse(points);
                    points = Console.ReadLine();
                }

                Console.WriteLine($"{nameOfCooker} has {pointsOfCooker} points.");

                if (pointsOfCooker > poinstsValue)
                {
                    poinstsValue = pointsOfCooker;
                    winnerName = nameOfCooker;
                    Console.WriteLine($"{nameOfCooker} is the new number 1!");
                }
            }
            
            Console.WriteLine($"{winnerName} won competition with {poinstsValue} points!");
        }
    }
}
