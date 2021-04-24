using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> stores = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                string store = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!stores.ContainsKey(store))
                {
                    stores.Add(store, new Dictionary<string, double>());
                }

                stores[store].Add(product, price);

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var store in stores)
            {
                Console.WriteLine($"{store.Key}->");

                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
