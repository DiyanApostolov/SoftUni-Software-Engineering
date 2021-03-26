using System;

namespace _06.Salary

{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int facebook = 0;
            int instagram = 0;
            int reddit = 0;

            for (int i = 0; i < numberOfTabs; i++)
            {
                string platform = Console.ReadLine();
                if (platform == "Facebook")
                {
                    facebook += 150;
                }
                if (platform == "Instagram")
                {
                    instagram += 100;
                }
                if (platform == "Reddit")
                {
                    reddit += 50;
                }
            }
            
            int totalMoney = salary - facebook - instagram - reddit;

            if (totalMoney <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                
                Console.WriteLine(totalMoney);
            }
        }
    }
}
