using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var randomList = new RandomList
            {
                "Ivan",
                "Pesho",
                "Gosho"
            };

            Console.WriteLine(randomList.RandomString());
        }
    }
}
