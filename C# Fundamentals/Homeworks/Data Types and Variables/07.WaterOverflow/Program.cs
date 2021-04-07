using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            
            int input = int.Parse(Console.ReadLine());

            int currentLittres = 0;

            for (int i = 1; i <= input; i++)
            {
                int addLittres = int.Parse(Console.ReadLine());
                currentLittres += addLittres;
                
                if (currentLittres > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    currentLittres -= addLittres;
                }
            }
            
            Console.WriteLine(currentLittres);    
        }
    }
}
