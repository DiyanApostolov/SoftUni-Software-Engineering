using System;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
        }
    }
}
