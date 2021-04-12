using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountPurchasedFood = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int eateanFood = 0;

            while (input != "Adopted")
            {
                eateanFood += Convert.ToInt32(input);

                input = Console.ReadLine();
            }
            
            int totalFood = 1000 * amountPurchasedFood - eateanFood;
            
            if (totalFood >= 0)
            {               
                Console.WriteLine($"Food is enough! Leftovers: {totalFood} grams.");
            }
            else
            {               
                Console.WriteLine($"Food is not enough. You need {Math.Abs(totalFood)} grams more.");
            }
        }
    }
}
