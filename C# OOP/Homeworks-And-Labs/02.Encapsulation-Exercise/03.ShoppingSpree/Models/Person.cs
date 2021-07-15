namespace _03.ShoppingSpree.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private int money;
        private readonly List<Product> bagOfProducts;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }

        public string Name 
        {
            get => this.name;
            set
            {
                ValidateName(value);
                this.name = value;
            }
        }

        public int Money
        {
            get => this.money;
            set
            {
                ValidateMoney(value);
                this.money = value;
            }
        }

        public string AddProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.bagOfProducts.Add(product);

            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            if (this.bagOfProducts.Count == 0)
            {
                return $"{this.name} - Nothing bought";
            }
            else
            {
                return $"{this.name} - {string.Join(", ", bagOfProducts)}";
            }
        }

        private void ValidateName(string targetName)
        {
            if (String.IsNullOrWhiteSpace(targetName) || String.IsNullOrEmpty(targetName))
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        private void ValidateMoney(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
}
