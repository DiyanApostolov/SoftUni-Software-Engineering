namespace Bakery.Models.BakedFoods
{
    public class Cake : BakedFood
    {
        private const int initialCakePortion = 245;
        public Cake(string name, decimal price) 
            : base(name, initialCakePortion, price)
        {
        }
    }
}
