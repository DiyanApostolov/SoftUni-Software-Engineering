using System;

namespace _08.OnTimeForTheExam

{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int diference = 0;
            int hour = 0;
            int minutes = 0;

            examMinutes += examHour * 60;
            arrivalMinutes += arrivalHour * 60;

            if (arrivalMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                diference = arrivalMinutes - examMinutes;
                if (diference < 60)
                {
                    Console.WriteLine($"{diference} minutes after the start");
                }
                else
                {
                    hour = diference / 60;
                    minutes = diference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalMinutes == examMinutes)
            {
                Console.WriteLine("On time");
            }
            else if (arrivalMinutes < examMinutes - 30)
            {
                Console.WriteLine("Early");
                diference = examMinutes - arrivalMinutes;
                if (diference < 60)
                {
                    Console.WriteLine($"{diference} minutes before the start");
                }
                else
                {
                    hour = diference / 60;
                    minutes = diference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else if (arrivalMinutes < examMinutes)
            {
                Console.WriteLine("On time");
                diference = examMinutes - arrivalMinutes;
                if (diference < 60)
                {
                    Console.WriteLine($"{diference} minutes before the start");
                }
                else
                {
                    hour = diference / 60;
                    minutes = diference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
        }
    }
}
