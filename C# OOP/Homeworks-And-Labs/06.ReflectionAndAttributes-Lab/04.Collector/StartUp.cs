namespace _04.Collector
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.CollectGettersAndSetters("Hacker");

            Console.WriteLine(result);
        }
    }
}
