namespace _03.Telephony
{
    using _03.Telephony.Contracts;
    using _03.Telephony.Core;
    using _03.Telephony.Models;

    public class StartUp
    {
        static void Main(string[] args)
        {
            ICallable caller = new Smartphone();
            ICallable dialler = new StationaryPhone();
            IBrowsable browser = new Smartphone();
            Engine engine = new Engine(caller, dialler, browser);

            engine.Run();
        }
    }
}
