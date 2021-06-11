namespace ClassroomProject
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return $"Student: First Name = {FirstName}, Last Name = {LastName}, Subject = {Subject}";
        }
    }
}
