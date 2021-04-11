using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstname = input[0];
                string lasttname = input[1];
                string grade = input[2];
                Student newStudent = new Student(firstname, lasttname, grade);
                students.Add(newStudent);
            }
            students = students.OrderByDescending(grade => grade.Grade ).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
