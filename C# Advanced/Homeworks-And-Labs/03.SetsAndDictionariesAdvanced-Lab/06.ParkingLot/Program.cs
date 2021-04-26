using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> parkingLot = new HashSet<string>();

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    parkingLot.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    parkingLot.Remove(input[1]);
                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
