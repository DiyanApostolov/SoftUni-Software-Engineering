namespace ClassroomProject
{
    using System;
    using System.Collections.Generic;

    public class Classroom
    {
        List<Student> students = new List<Student>();

        public Classroom(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; set; }

        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            List<int> studentsPosition = new List<int>();
            int counter = 0;

            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    studentsPosition.Add(counter);

                    return $"Dismissed student {firstName} {lastName}";
                }
                else
                {
                    return "Student not found";
                }
                counter++;
            }
        }
    }
}
