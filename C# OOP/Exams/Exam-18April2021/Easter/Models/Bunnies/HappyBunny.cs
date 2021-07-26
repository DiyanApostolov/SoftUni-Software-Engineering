namespace Easter.Models.Bunnies
{
    using System;

    public class HappyBunny : Bunny
    {
        private const int initialEnergy = 100;
        public HappyBunny(string name) 
            : base(name, initialEnergy)
        {
        }
    }
}
