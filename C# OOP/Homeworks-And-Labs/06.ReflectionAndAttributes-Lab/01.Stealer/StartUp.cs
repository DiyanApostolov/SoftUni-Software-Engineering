namespace _01.Stealer
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.StealFieldInfo("Hacker", "username", "password");

            Console.WriteLine(result);
        }
    }
}
