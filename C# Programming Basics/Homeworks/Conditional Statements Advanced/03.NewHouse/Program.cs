using System;
using System.Transactions;
using System.Xml;

namespace _03.NewHouse

{
    class Program
    {
        static void Main(string[] args)
        {

            double rosesPrice = 5;
            double dahliasPrice = 3.8;
            double tulipsPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.5;

            string typeOfFlower = Console.ReadLine();
            int quantityFlower = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            switch (typeOfFlower)
            {
                case "Roses":
                    if (quantityFlower > 80)
                    {
                        rosesPrice -= rosesPrice * 0.1;
                    }
                    totalPrice = quantityFlower * rosesPrice;
                    break;
                case "Dahlias":
                    if (quantityFlower > 90)
                    {
                        dahliasPrice -= dahliasPrice * 0.15;
                    }
                    totalPrice = quantityFlower * dahliasPrice;
                    break;
                case "Tulips":
                    if (quantityFlower > 80)
                    {
                        tulipsPrice -= tulipsPrice * 0.15;
                    }
                    totalPrice = quantityFlower * tulipsPrice;
                    break;
                case "Narcissus":
                    if (quantityFlower < 120)
                    {
                        narcissusPrice += narcissusPrice * 0.15;
                    }
                    totalPrice = quantityFlower * narcissusPrice;
                    break;
                case "Gladiolus":
                    if (quantityFlower < 80)
                    {
                        gladiolusPrice += gladiolusPrice * 0.2;
                    }
                    totalPrice = quantityFlower * gladiolusPrice;
                    break;
            }
            
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantityFlower} {typeOfFlower} and {(budget - totalPrice):f2} leva left.");
            }
            else if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");
            }
        }
    }
}
