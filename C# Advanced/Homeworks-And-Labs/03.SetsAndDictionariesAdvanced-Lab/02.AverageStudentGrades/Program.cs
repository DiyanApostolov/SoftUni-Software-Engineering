using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<decimal>());
                }

                students[student].Add(grade);
            }


            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                decimal average = item.Value.Average();
                Console.Write($"(avg: {average:F2})");
                Console.WriteLine();
            }
        }
    }
}
