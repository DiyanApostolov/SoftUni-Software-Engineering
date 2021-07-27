namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int comfort = 5;
        private const decimal price = 10;

        public Plant() 
            : base(comfort, price)
        {
        }
    }
}
