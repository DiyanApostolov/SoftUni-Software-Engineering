namespace _03.Telephony.Models
{
    using System;
    using System.Linq;
    using _03.Telephony.Contracts;

    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (number.Any(x => char.IsLetter(x)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
        }
        public string Browse(string site)
        {
            if (site.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {site}!";
        }

    }
}
