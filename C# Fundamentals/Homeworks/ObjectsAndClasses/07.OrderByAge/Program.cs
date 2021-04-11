using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Person> listOfPersons = new List<Person>();

            while (input[0] != "End")
            {
                Person currentPerson = new Person(input[0], input[1], int.Parse(input[2]));
                listOfPersons.Add(currentPerson);

                input = Console.ReadLine().Split();
            }

            listOfPersons = listOfPersons.OrderBy(a => a.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, listOfPersons));
        }

        public class Person
        {
            public Person(string name, string iD, int age)
            {
                Name = name;
                ID = iD;
                Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }     
    }
}
