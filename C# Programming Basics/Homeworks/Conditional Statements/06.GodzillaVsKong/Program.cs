using System;

namespace _06.GodzillaVsKong

{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double cost = double.Parse(Console.ReadLine());
            int numbetStatist = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            //Calculations
            double decore = cost * 0.1;
            
            if (numbetStatist > 150)
            {
                priceForClothes *= 0.9; 
            }
            double finalpriceForClothes = numbetStatist * priceForClothes;
            double finalMoney = decore + finalpriceForClothes;

            if (finalMoney > cost)
            {
                double moneyNeed = finalMoney - cost;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeed:f2} leva more.");
            }
            else if (finalMoney <= cost) 
            {
                double moneyLeft = cost - finalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
