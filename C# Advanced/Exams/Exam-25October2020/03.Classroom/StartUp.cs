namespace ClassroomProject
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Classroom classroom = new Classroom(10);
            // Initialize entities
            Student student = new Student("Peter", "Parker", "Geometry");
            Student studentTwo = new Student("Sarah", "Smith", "Algebra");
            Student studentThree = new Student("Sam", "Winchester", "Algebra");
            Student studentFour = new Student("Dean", "Winchester", "Music");
            Console.WriteLine(student); // Student: First Name = Peter, Last Name = Parker, Subject = Geometry
            // Register Student
            string register = classroom.RegisterStudent(student);
            Console.WriteLine(register); // Added student Peter Parker
            string registerTwo = classroom.RegisterStudent(studentTwo);
            string registerThree = classroom.RegisterStudent(studentThree);
            string registerFour = classroom.RegisterStudent(studentFour);
            // Dismiss Student
            string dismissed = classroom.DismissStudent("Peter", "Parker");
            Console.WriteLine(dismissed); // Dismissed student Peter Parker
            string dismissedTwo = classroom.DismissStudent("Ellie", "Goulding");
            Console.WriteLine(dismissedTwo); // Student not found


        }
    }
}