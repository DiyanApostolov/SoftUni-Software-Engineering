using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            
            string[] contestAndPassword = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

            while (contestAndPassword[0] != "end of contests")
            {
                string contest = contestAndPassword[0];
                string password = contestAndPassword[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, "");
                }

                contests[contest] = password;

                contestAndPassword = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
            }

            var students = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string pass = tokens[1];
                string name = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!students.ContainsKey(name) && contests.ContainsKey(contest) && contests[contest] == pass)
                {
                    students.Add(name, new Dictionary<string, int>());
                    students[name].Add(contest, points);
                }
                else if (students.ContainsKey(name) && contests.ContainsKey(contest) && contests[contest] == pass)
                {
                    if (!students[name].ContainsKey(contest))
                    {
                        students[name].Add(contest, points);
                    }

                    if (points > students[name][contest])
                    {
                        students[name][contest] = points;
                    }
                }

                input = Console.ReadLine();
            }

            string bestStudent = string.Empty;
            int bestStudentPoints = 0;

            foreach (var student in students)
            {
                int studentPoints = 0;

                foreach (var point in student.Value)
                {
                    studentPoints += point.Value;
                }

                if (studentPoints > bestStudentPoints)
                {
                    bestStudentPoints = studentPoints;
                    bestStudent = student.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestStudentPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var student in students.OrderBy(s => s.Key))
            {
                Console.WriteLine(student.Key);

                foreach (var contest in student.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
