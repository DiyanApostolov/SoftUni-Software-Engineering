using System;

namespace _03.Vacation

{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            switch (typeOfGroup)
            {
                case ("Students"):
                    switch (dayOfWeek)
                    {
                        case ("Friday"):
                            price = 8.45;
                            break;
                        case ("Saturday"):
                            price = 9.8;
                            break;
                        case ("Sunday"):
                            price = 10.46;
                            break;
                    }
                    
                    if (numberOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                    
                    break;
                case ("Business"):
                    switch (dayOfWeek)
                    {
                        case ("Friday"):
                            price = 10.9;
                            break;
                        case ("Saturday"):
                            price = 15.6;
                            break;
                        case ("Sunday"):
                            price = 16;
                            break;
                    }
                    
                    if (numberOfPeople >= 100)
                    {
                        numberOfPeople -= 10;
                    }
                    
                    break;
                case ("Regular"):
                    switch (dayOfWeek)
                    {
                        case ("Friday"):
                            price = 15;
                            break;
                        case ("Saturday"):
                            price = 20;
                            break;
                        case ("Sunday"):
                            price = 22.5;
                            break;
                    }
                    
                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        price *= 0.95;
                    }
                    break;
            }
            
            double totalPrice = numberOfPeople * price;
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
