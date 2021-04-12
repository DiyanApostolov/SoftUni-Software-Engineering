using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double workerProductivityPerDay = double.Parse(Console.ReadLine());
            double countOfWorkers = double.Parse(Console.ReadLine());
            double otherFactoryBiscuits = double.Parse(Console.ReadLine());

            double biscuitsFor30Days = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    biscuitsFor30Days += Math.Floor(workerProductivityPerDay * countOfWorkers * 0.75);
                }
                else
                {
                    biscuitsFor30Days += workerProductivityPerDay * countOfWorkers;
                }
            }

            Console.WriteLine($"You have produced {biscuitsFor30Days} biscuits for the past month.");

            if (biscuitsFor30Days > otherFactoryBiscuits)
            {
                double diference = (biscuitsFor30Days - otherFactoryBiscuits) / otherFactoryBiscuits * 100;
                Console.WriteLine($"You produce {diference:F2} percent more biscuits.");
            }
            else
            {
                double diference = (otherFactoryBiscuits - biscuitsFor30Days) / otherFactoryBiscuits * 100;
                Console.WriteLine($"You produce {diference:F2} percent less biscuits.");
            }
        }
    }
}
