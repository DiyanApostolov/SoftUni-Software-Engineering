using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPerson = int.Parse(Console.ReadLine());
            int pPerson = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)nPerson / pPerson);

            Console.WriteLine(courses);
        }
    }
}
