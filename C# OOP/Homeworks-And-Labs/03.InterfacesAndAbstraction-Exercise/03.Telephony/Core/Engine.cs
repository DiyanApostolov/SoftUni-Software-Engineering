namespace _03.Telephony.Core
{
    using System;
    using System.Linq;
    using _03.Telephony.Models;
    using Contracts;

    public class Engine
    {
        private ICallable caller;
        private ICallable dialler;
        private IBrowsable browser;

        public Engine(ICallable caller, ICallable dialler, IBrowsable browser)
        {
            this.caller = caller;
            this.dialler = dialler;
            this.browser = browser;
        }

        public void Run()
        {
            var phoneNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var sites = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            CallNumbers(phoneNumbers);
            BrowseSites(sites);
        }

        private void CallNumbers(string[] phoneNumbers)
        {
            foreach (var number in phoneNumbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        Console.WriteLine(this.caller.Call(number));
                    }
                    else if (number.Length == 7)
                    {
                        Console.WriteLine(this.dialler.Call(number));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid number!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }

        private void BrowseSites(string[] sites)
        {
            foreach (var site in sites)
            {
                try
                {
                    Console.WriteLine(this.browser.Browse(site));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }

    }
}
