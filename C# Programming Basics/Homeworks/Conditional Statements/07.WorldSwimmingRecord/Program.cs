using System;

namespace _07.WorldSwimmingRecord

{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            // Calculations
            double distanceInSeconds = distance * secondsPerMeter;
            double resistance =  Math.Floor(distance / 15) * 12.5;
            double allTime = distanceInSeconds + resistance;
            
            // Output
            if (allTime < record)
            {          
                Console.WriteLine($" Yes, he succeeded! The new world record is {allTime:f2} seconds.");
            }
            else
            {
                double needTime = allTime - record;
                Console.WriteLine($"No, he failed! He was {needTime:f2} seconds slower.");
            }
        }
    }
}
