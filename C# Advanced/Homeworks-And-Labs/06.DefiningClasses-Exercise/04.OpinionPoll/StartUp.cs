using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = personInfo[0];
                int personAge = int.Parse(personInfo[1]);

                Person currentPerson = new Person(personName, personAge);

                persons.Add(currentPerson);
            }

            foreach (var person in persons
                .OrderBy(p => p.Name)
                .Where(p => p.Age > 30))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
