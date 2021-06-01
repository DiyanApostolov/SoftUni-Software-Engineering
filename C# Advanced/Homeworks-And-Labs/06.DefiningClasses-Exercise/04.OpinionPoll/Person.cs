namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
        {
            Name = "No name";
            Age = age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }


    }
}
