using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            Car secondCar = new Car("VW", "MK3", 1992);
            Car thirdCar = new Car("VW", "Passat", 2002, 200, 6.5);
        }
    }
}
