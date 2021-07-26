namespace Easter.Models.Eggs
{
    using Easter.Models.Eggs.Contracts;

    public class Egg : IEgg
    {
        public string Name => throw new System.NotImplementedException();

        public int EnergyRequired => throw new System.NotImplementedException();

        public void GetColored()
        {
            throw new System.NotImplementedException();
        }

        public bool IsDone()
        {
            throw new System.NotImplementedException();
        }
    }
}
