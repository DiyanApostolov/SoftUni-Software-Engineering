﻿namespace _07.RawData
{
    public class Tire
    {
        public int Age { get; set; }

        public double Pressure { get; set; }

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
    }
}
