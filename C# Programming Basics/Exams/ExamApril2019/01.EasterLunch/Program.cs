using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double kozunak = 3.20;
            double eggBox = 4.35;
            double cookies = 5.40;
            double eggPaint = 0.15;

            double numberKozinaci = double.Parse(Console.ReadLine());
            double numberEggsBox = double.Parse(Console.ReadLine());
            double kgCookies = double.Parse(Console.ReadLine());

            double priceForKozunak = numberKozinaci * kozunak;
            double priceForEggs = numberEggsBox * eggBox;
            double priceForCookies = kgCookies * cookies;
            double priceForEggsPaint = numberEggsBox * 12 * eggPaint;

            double totalMoney = priceForKozunak + priceForEggs + priceForCookies + priceForEggsPaint;

            Console.WriteLine($"{totalMoney:f2}");

        }
    }
}
