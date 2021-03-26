using System;

namespace _08.Scholarship

{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            //Calculations
            double socialSchoolarship = Math.Floor(minimalSalary * 0.35);
            double excellentSchoolarship = Math.Floor(averageGrade * 25);

            if (income >= minimalSalary && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialSchoolarship} BGN");
            }
            else if (income >= minimalSalary && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentSchoolarship} BGN");
            }
            else if (income < minimalSalary && averageGrade >= 5.5 && socialSchoolarship <= excellentSchoolarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentSchoolarship} BGN");
            }
            else if (income < minimalSalary && averageGrade <= 4.5)
            { 
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
