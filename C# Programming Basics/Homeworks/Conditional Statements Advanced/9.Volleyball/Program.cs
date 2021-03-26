using System;

namespace _9.Volleyball

{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - weekends;
            double weekendsSofiaForPlay = weekendsInSofia * 3.0 / 4.0;
            double holidayPlaysInSofia = holidays * 2.0 / 3.0;

            double plays = holidayPlaysInSofia + weekends + weekendsSofiaForPlay;

            if (year == "leap")
            {
                plays *= 1.15;
            }
            
            Console.WriteLine(Math.Floor(plays));
        }
    }
}
