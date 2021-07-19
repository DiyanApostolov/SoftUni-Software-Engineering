namespace _03.MissionPrivatImpossible
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.RevealPrivateMethods("Hacker");

            Console.WriteLine(result);
        }
    }
}
