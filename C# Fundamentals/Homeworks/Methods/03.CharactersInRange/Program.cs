using System;
using System.Linq;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharacter(firstChar, secondChar);
        }

        public static void PrintCharacter(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                char first = firstChar;
                firstChar = secondChar;
                secondChar = first;
            }
          
            int range = secondChar - firstChar - 1;
            int couter = 0;

            char[] array = new char [range];

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                char currentChar = Convert.ToChar(i);
                array[couter] = currentChar;
                couter++;
            }
            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
