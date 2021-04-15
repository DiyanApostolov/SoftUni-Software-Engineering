using System;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfLectures = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());
           
            double maxAttendances = 0;
            double maxBonus = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double studentAttendances = double.Parse(Console.ReadLine());
                double totalBonus = Math.Ceiling(studentAttendances / numberOfLectures * (5 + additionalBonus));

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendances = studentAttendances;
                }
            }
            
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}

