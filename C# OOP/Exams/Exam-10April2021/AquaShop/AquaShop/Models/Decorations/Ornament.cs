namespace AquaShop.Models.Decorations
{
    using System;

    public class Ornament : Decoration
    {
        private const int comfort = 1;
        private const decimal price = 5;

        public Ornament() 
            : base(comfort, price)
        {
        }
    }
}
