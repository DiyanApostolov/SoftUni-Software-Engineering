namespace Bakery.Core
{
    using System;

    using Bakery.Core.Contracts;

    public class Controller : IController
    {
        public string AddDrink(string type, string name, int portion, string brand)
        {
            throw new NotImplementedException();
        }

        public string AddFood(string type, string name, decimal price)
        {
            throw new NotImplementedException();
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            throw new NotImplementedException();
        }

        public string GetFreeTablesInfo()
        {
            throw new NotImplementedException();
        }

        public string GetTotalIncome()
        {
            throw new NotImplementedException();
        }

        public string LeaveTable(int tableNumber)
        {
            throw new NotImplementedException();
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            throw new NotImplementedException();
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            throw new NotImplementedException();
        }

        public string ReserveTable(int numberOfPeople)
        {
            throw new NotImplementedException();
        }
    }
}
