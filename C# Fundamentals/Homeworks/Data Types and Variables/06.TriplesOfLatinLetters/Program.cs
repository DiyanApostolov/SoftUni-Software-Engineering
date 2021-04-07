using System;

namespace _06.TriplesOfLatinLetters

{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());           

            for (int i = 97; i < 97 + input; i++)
            {
                for (int j = 97; j < 97 + input; j++)
                {
                    for (int k = 97; k < 97 + input; k++)
                    {
                        char firstChar = (char)i;
                        char secondChar = (char)j;
                        char thirdChar = (char)k;
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }                                           
            }
        }
    }
}
