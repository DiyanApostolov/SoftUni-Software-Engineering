namespace _03.ShoppingSpree.Models
{
    using System;

    public class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public int Cost
        {
            get => this.cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }
}
