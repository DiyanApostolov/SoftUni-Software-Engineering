namespace Easter.Models.Dyes
{
    using Easter.Models.Dyes.Contracts;

    public class Dye : IDye
    {
        public Dye(int power)
        {
            this.Power = power;
        }

        public int Power { get; private set; }

        public void Use()
        {
            this.Power -= 10;

            if (this.Power < 0)
            {
                this.Power = 0;
            }
        }

        public bool IsFinished()
        {
            return this.Power == 0; 
        }
    }
}
