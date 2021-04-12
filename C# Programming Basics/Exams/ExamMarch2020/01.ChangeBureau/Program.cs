using System;

namespace _01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {

            // Constants
            double dollarPrice = 1.76;
            double euroPrice = 1.95;
            double bitcoinPrice = 1168;
            double chineseUanPrice = 0.15 * dollarPrice;
            
            // Input 
            int bitcoinAmount = int.Parse(Console.ReadLine());
            double chineseUanAmount = double.Parse(Console.ReadLine());
            double comissionAmount = double.Parse(Console.ReadLine());

            // Calculations
            double bitcoins = bitcoinAmount * bitcoinPrice;
            double uans = (chineseUanAmount * chineseUanPrice);
            double sum = (bitcoins + uans) / euroPrice;
            double comission = sum - (sum * ((100 - comissionAmount) / 100));
            double result = sum - comission;


            // Output

            Console.WriteLine($"{result:f2}");
        }       
    }
}
