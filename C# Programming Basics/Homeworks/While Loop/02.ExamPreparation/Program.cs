using System;

namespace _02.ExamPreparation

{
    class Program
    {
        static void Main(string[] args)
        {
            int weakValue = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int weakScores = 0;
            int numberOfScores = 0;
            double sumOfScores = 0;
            string lastProblem = "";

            while (input != "Enough")
            {
                double score = double.Parse(Console.ReadLine());
                numberOfScores++;
                sumOfScores += score;
                lastProblem = input;
                if (score <= 4)
                {
                    weakScores++;
                    if (weakScores == weakValue)
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            
            if (input == "Enough")
            {
                double averageScore = sumOfScores / numberOfScores;
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {numberOfScores}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {weakScores} poor grades.");
            }
        }
    }
}
