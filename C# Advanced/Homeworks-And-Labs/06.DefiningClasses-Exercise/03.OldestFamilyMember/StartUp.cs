using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personName = person[0];
                int personAge = int.Parse(person[1]);

                Person member = new Person(personName, personAge);
                family.Add(member);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
