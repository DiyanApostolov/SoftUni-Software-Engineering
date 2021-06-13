namespace ClassroomProject
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Classroom
    {
        readonly List<Student> students = new List<Student>();
        
        public Classroom(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; set; }
        public int Count { get 
            { 
                return students.Count; 
            } 
        }

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
            Student studentToRemove = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($"Students:");
            bool isFound = false;

            foreach (var student in students)
            {
                if (student.Subject == subject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                    isFound = true;
                }
            }

            if (isFound)
            {
                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student currentStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            return currentStudent;
        }
    }
}
