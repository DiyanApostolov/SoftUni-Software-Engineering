using System;

namespace _08.BeerKegs

{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            double winnerKeg = 0;
            string nameWinner = "";

            for (int i = 1; i <= numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double capacity = Math.PI * Math.Pow(radius, 2) * height;

                if (capacity > winnerKeg)
                {
                    winnerKeg = capacity;
                    nameWinner = model;
                }
            }
            
            Console.WriteLine(nameWinner);
        }
    }
}
