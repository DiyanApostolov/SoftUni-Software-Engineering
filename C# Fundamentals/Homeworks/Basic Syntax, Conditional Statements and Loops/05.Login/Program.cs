using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = string.Empty;
            int counter = 0;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                pass += user[i];
            }

            while (true)
            {
                string currentPass = Console.ReadLine();
                counter++;

                if (currentPass == pass)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                
                if (counter == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
                
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
