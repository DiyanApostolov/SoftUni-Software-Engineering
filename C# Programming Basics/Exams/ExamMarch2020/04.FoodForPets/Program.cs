using System;
 
namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodCount = double.Parse(Console.ReadLine());
 
            double biscuits = 0;
            double eatenFoodDog = 0;
            double eatenFoodCat = 0;
 
            for (int i = 1; i <= days; i++)
            {
                double foodDog = double.Parse(Console.ReadLine());
                double foodCat = double.Parse(Console.ReadLine());
 
                eatenFoodDog += foodDog;
                eatenFoodCat += foodCat;
 
                if (i % 3 == 0)
                {
                    double currentBiscuits = (foodDog + foodCat) * 0.1;
                    biscuits += currentBiscuits;
                } 
            }
            
            double allEatenFood = eatenFoodDog + eatenFoodCat;
            double percentFood = (allEatenFood / foodCount) * 100;
            double percentDog = (eatenFoodDog / allEatenFood) * 100;
            double percentCat = (eatenFoodCat / allEatenFood) * 100;
 
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentFood:F2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:F2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:F2}% eaten from the cat.");
        }
    }
}
