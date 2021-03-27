using System;

namespace _05.PasswordGenerator

{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 < firstNumber; i1++)
            {
                for (int i2 = 1; i2 < firstNumber; i2++)
                {
                    for (int i3 = 'a'; i3 < 'a'+secondNumber; i3++)
                    {
                        for (int i4 = 'a'; i4 < 'a'+secondNumber; i4++)
                        {
                            for (int i5 = 2; i5 <= firstNumber; i5++)
                            {
                                if (i5 > i1 && i5 > i2)
                                {
                                    Console.Write($"{i1}{i2}{(char)i3}{(char)i4}{i5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
