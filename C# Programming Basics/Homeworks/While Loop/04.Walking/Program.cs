using System;

namespace _04.Walking

{
    class Program
    {
        static void Main(string[] args)
        {           
            int allSteps = 0;

            while (allSteps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    allSteps += Convert.ToInt32(input);
                    break;
                }               
                allSteps += Convert.ToInt32(input);                          
            }
            
            if (allSteps >= 10000)
            {
                int stepsOver = allSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                int stepsNeeded = 10000 - allSteps;
                Console.WriteLine($"{stepsNeeded} more steps to reach goal.");
            }
        }
    }
}

