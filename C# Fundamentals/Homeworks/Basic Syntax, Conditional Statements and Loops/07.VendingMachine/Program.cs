using System;

namespace _07.VendingMachine

{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double money = 0;

            while (input != "Start")
            {
                double insertedCoin = double.Parse(input);

                if (insertedCoin == 0.1 || insertedCoin == 0.2 || insertedCoin == 0.5 || insertedCoin == 1 || insertedCoin == 2)
                {
                    money += insertedCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedCoin}");
                }

                input = Console.ReadLine();
            }

            string purcahase = Console.ReadLine();
            double productPrice = 0;
            bool invalidProduct = true;

            while (purcahase != "End")
            {
                switch (purcahase)
                {
                    case ("Nuts"):
                        productPrice = 2.0;
                        break;
                    case ("Water"):
                        productPrice = 0.7;
                        break;
                    case ("Crisps"):
                        productPrice = 1.5;
                        break;
                    case ("Soda"):
                        productPrice = 0.8;
                        break;
                    case ("Coke"):
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        purcahase = Console.ReadLine();
                        continue;
                }
              
                if (productPrice <= money)
                {
                    money -= productPrice;
                    Console.WriteLine($"Purchased {purcahase.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");

                }
                purcahase = Console.ReadLine();
            }
            
            Console.WriteLine($"Change: {money:F2}");
        }
    }
}
