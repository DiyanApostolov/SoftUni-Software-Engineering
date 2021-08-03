namespace Bakery.Models.Drinks
{
    public class Water : Drink
    {
        private const decimal waterPrice = 1.50M;

        public Water(string name, int portion, string brand) 
            : base(name, portion, waterPrice, brand)
        {
        }
    }
}
