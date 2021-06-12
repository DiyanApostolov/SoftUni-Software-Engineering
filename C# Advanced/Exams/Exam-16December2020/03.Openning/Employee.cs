namespace BakeryOpenning
{
    using System;

    public class Employee
    {
        public Employee(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Employee: {Name}, {Age} ({Country})";
        }
    }
}
