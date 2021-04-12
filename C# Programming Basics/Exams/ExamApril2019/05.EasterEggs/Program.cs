using System;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int numberOfEggs = int.Parse(Console.ReadLine());

            int redEgg = 0;
            int orangeEgg = 0;
            int blueEgg = 0;
            int greenEgg = 0;

            for (int i = 0; i < numberOfEggs; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        redEgg++;
                        break;
                    case "orange":
                        orangeEgg++;
                        break;
                    case "blue":
                        blueEgg++;
                        break;
                    case "green":
                        greenEgg++;
                        break;
                }

            }
            
            string colourWithMaxValue = "";

            if (redEgg > orangeEgg && redEgg > blueEgg && redEgg > greenEgg)
            {
                colourWithMaxValue = "red";
            }
            else if (orangeEgg > redEgg && orangeEgg > blueEgg && orangeEgg > greenEgg)
            {
                colourWithMaxValue = "orange";
            }
            else if (blueEgg > redEgg && blueEgg > orangeEgg && blueEgg > greenEgg)
            {
                colourWithMaxValue = "blue";
            }
            else if (greenEgg > redEgg && greenEgg > orangeEgg && greenEgg > blueEgg)
            {
                colourWithMaxValue = "green";
            }

            Console.WriteLine($"Red eggs: {redEgg}");
            Console.WriteLine($"Orange eggs: {orangeEgg}");
            Console.WriteLine($"Blue eggs: {blueEgg}");
            Console.WriteLine($"Green eggs: {greenEgg}");
            Console.WriteLine($"Max eggs: {(Math.Max(Math.Max(Math.Max(redEgg, orangeEgg), blueEgg), greenEgg))} -> {colourWithMaxValue}");
            

        }
    }
}
