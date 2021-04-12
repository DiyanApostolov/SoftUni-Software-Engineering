using System;
using System.Numerics;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setPcs = int.Parse(Console.ReadLine());

            double allSetMelonPrise = 0;
            double allSetMangoPrise = 0;
            double allSetPineapplePrise = 0;
            double allSetRaspberryPrise = 0;

            if (setSize == "small")
            {
                allSetMelonPrise = setPcs * 112;
                allSetMangoPrise = setPcs * 73.32;
                allSetPineapplePrise = setPcs * 84.20;
                allSetRaspberryPrise = setPcs * 40;
            }
            else if (setSize == "big")
            {
                allSetMelonPrise = setPcs * 143.5;
                allSetMangoPrise = setPcs * 98;
                allSetPineapplePrise = setPcs * 124;
                allSetRaspberryPrise = setPcs * 76;
            }

            switch (fruit)
            {
                case "Watermelon":
                    if (allSetMelonPrise > 1000)
                    {
                        allSetMelonPrise *= 0.5;
                        Console.WriteLine($"{allSetMelonPrise:f2} lv.");
                    }
                    else if (allSetMelonPrise <= 1000 && allSetMelonPrise >= 400)
                    {
                        allSetMelonPrise -= (allSetMelonPrise * 0.15);
                        Console.WriteLine($"{allSetMelonPrise:f2} lv.");

                    }
                    else
                    { 
                        Console.WriteLine($"{allSetMelonPrise:f2} lv.");
                    }
                    break;
                case "Mango":
                    if (allSetMangoPrise > 1000)
                    {
                        allSetMangoPrise *= 0.5;
                        Console.WriteLine($"{allSetMangoPrise:f2} lv.");
                    }
                    else if (allSetMangoPrise <= 1000 && allSetMangoPrise >= 400)
                    {
                        allSetMangoPrise -= (allSetMangoPrise * 0.15);
                        Console.WriteLine($"{allSetMangoPrise:f2} lv.");

                    }
                    else
                    {
                        Console.WriteLine($"{allSetMangoPrise:f2} lv.");
                    }
                    break;
                case "Pineapple":
                    if (allSetPineapplePrise > 1000)
                    {
                        allSetPineapplePrise *= 0.5;
                        Console.WriteLine($"{allSetPineapplePrise:f2} lv.");
                    }
                    else if (allSetPineapplePrise <= 1000 && allSetPineapplePrise >= 400)
                    {
                        allSetPineapplePrise -= (allSetPineapplePrise * 0.15);
                        Console.WriteLine($"{allSetPineapplePrise:f2} lv.");

                    }
                    else
                    {
                        Console.WriteLine($"{allSetPineapplePrise:f2} lv.");
                    }
                    break;
                case "Raspberry":
                    if (allSetRaspberryPrise > 1000)
                    {
                        allSetRaspberryPrise *= 0.5;
                        Console.WriteLine($"{allSetRaspberryPrise:f2} lv.");
                    }
                    else if (allSetRaspberryPrise <= 1000 && allSetRaspberryPrise >= 400)
                    {
                        allSetRaspberryPrise -= (allSetRaspberryPrise * 0.15);
                        Console.WriteLine($"{allSetRaspberryPrise:f2} lv.");

                    }
                    else
                    {
                        Console.WriteLine($"{allSetRaspberryPrise:f2} lv.");
                    }
                    break;
            }
        }
    }
}
