namespace _03.Telephony.Models
{
    using System;
    using System.Linq;
    using _03.Telephony.Contracts;

    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (number.Any(x => char.IsLetter(x)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }
    }
}
