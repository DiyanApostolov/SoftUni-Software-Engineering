namespace ClassroomProject
{
    using System.Collections.Generic;
    using System.Text;

    public class Classroom
    {
        List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>(Capacity);
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
            Student studentToRemove = new Student(firstName, lastName, string.Empty);

            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    studentToRemove = student;
                    break;
                }
            }

            if (students.Contains(studentToRemove))
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
            return Count;
        }

        public string GetStudent(string firstName, string lastName)
        {
            Student getStudent = new Student(firstName, lastName, string.Empty);

            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    getStudent = student;
                    break;
                }
            }

            return $"Student: First Name = {getStudent.FirstName}, Last Name = {getStudent.LastName}, Subject = {getStudent.Subject}";
        }
    }
}
