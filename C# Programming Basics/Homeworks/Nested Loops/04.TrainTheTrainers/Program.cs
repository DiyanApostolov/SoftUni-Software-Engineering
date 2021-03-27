using System;

namespace _04.TrainTheTrainers

{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInJury = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();

            double averageScore = 0;
            double averageScoreAllPresentation = 0;
            int counter = 0;

            while (nameOfPresentation != "Finish")
            {
                averageScore = 0;
                
                for (int i = 1; i <= peopleInJury; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    averageScore += score;
                    averageScoreAllPresentation += score;
                    counter++;
                }
                
                double averageScorePerPresentation = averageScore / peopleInJury;
                Console.WriteLine($"{nameOfPresentation} - {averageScorePerPresentation:F2}.");
                
                nameOfPresentation = Console.ReadLine();
            }
            
            double assessment = averageScoreAllPresentation / counter;
            Console.WriteLine($"Student's final assessment is {assessment:F2}.");
        }
    }
}
