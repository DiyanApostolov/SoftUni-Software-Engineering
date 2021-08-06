﻿namespace AquaShop.Models.Decorations
{
    using AquaShop.Models.Decorations.Contracts;

    public abstract class Decoration : IDecoration
    {
        protected Decoration(int comfort, decimal price)
        {
            Comfort = comfort;
            Price = price;
        }

        public int Comfort { get; private set; }

        public decimal Price { get; private set; }
    }
}
