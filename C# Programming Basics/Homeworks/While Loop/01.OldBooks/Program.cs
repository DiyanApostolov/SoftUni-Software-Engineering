using System;

namespace _01.OldBooks

{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int count = 0;
            string firstBook = favouriteBook;

            while (favouriteBook != "No More Books")
            {
                
                favouriteBook = Console.ReadLine();
                if (favouriteBook == firstBook)
                {
                    break;
                }
                count++;
            }
            
            if (favouriteBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count - 1} books.");
            }
            else
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
        }
    }
}
