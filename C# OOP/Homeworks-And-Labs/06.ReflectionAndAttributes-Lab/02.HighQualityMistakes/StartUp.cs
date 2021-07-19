namespace _02.HighQualityMistakes
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.AnalyzeAcessModifiers("Hacker");

            Console.WriteLine(result);
        }
    }
}
