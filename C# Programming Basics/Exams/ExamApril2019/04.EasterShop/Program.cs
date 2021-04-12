using System;

namespace _04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentQuantityEgss = int.Parse(Console.ReadLine());
            int buyedEgss = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{buyedEgss} eggs sold.");
                    break;
                }

                if (command == "Buy")
                {
                    int eggsNumber = int.Parse(Console.ReadLine());
                    if (eggsNumber > currentQuantityEgss)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {currentQuantityEgss}.");
                        break;
                    }
                    currentQuantityEgss -= eggsNumber;
                    buyedEgss += eggsNumber;
                }
                else if (command == "Fill")
                {
                    int eggsNumber = int.Parse(Console.ReadLine());
                    currentQuantityEgss += eggsNumber;
                }            
            }
        }
    }
}
