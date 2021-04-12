using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int walkInMinutes = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            double caloriesPerDay = double.Parse(Console.ReadLine());

            double razhodCaloriesPerWalk = walkInMinutes * 5;
            double razhodCaloriesPedDay = razhodCaloriesPerWalk * walksPerDay;
            
            // Output
            if (razhodCaloriesPedDay >= caloriesPerDay * 0.5)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {razhodCaloriesPedDay}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {razhodCaloriesPedDay}.");
            }
        }
    }
}
