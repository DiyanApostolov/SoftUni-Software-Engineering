namespace _03.ShoppingSpree.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public class Engine
    {
        private List<Person> persons;
        private List<Product> products;

        public Engine()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                ReadPeopleInfo();
                ReadProductInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                try
                {
                    string[] nameAndPurchase = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string name = nameAndPurchase[0];
                    string purchase = nameAndPurchase[1];

                    var currentPerson = persons.FirstOrDefault(p => p.Name == name);
                    var currentProduct = products.FirstOrDefault(p => p.Name == purchase);

                    Console.WriteLine(currentPerson.AddProduct(currentProduct));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }


        private void ReadPeopleInfo()
        {
            string peopleInput = Console.ReadLine();

            string[] cmdArg = peopleInput
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < cmdArg.Length; j++)
            {
                string[] tokens = cmdArg[j]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int money = int.Parse(tokens[1]);

                var person = new Person(name, money);
                this.persons.Add(person);

            }
        }

        private void ReadProductInfo()
        {
            string productInput = Console.ReadLine();

            string[] cmdArg = productInput
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < cmdArg.Length; j++)
            {
                string[] tokens = cmdArg[j]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int money = int.Parse(tokens[1]);

                var product = new Product(name, money);
                this.products.Add(product);

            }
        }
    }
}
