using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peronOne = new Person("Gogi", 16);

            Person personTwo = new Person();

            personTwo.Name = "Didmitrichko";
            personTwo.Age = 18;
        }
    }
}
