namespace Easter.Models.Bunnies
{
    using System;
    using System.Collections.Generic;
    using Easter.Models.Bunnies.Contracts;
    using Easter.Models.Dyes.Contracts;
    using Easter.Utilities.Messages;

    public abstract class Bunny : IBunny
    {
        private string name;
        private readonly ICollection<IDye> dyes;

        protected Bunny(string name, int energy)
        {
            this.Name = name;
            this.Energy = energy;
            this.dyes = new List<IDye>();
        }

        public string Name 
        {
            get => this.name;
            
           private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBunnyName);
                }

                this.name = value;
            }
        }

        public int Energy { get; protected set; }

        public ICollection<IDye> Dyes { get => dyes; }

        public void AddDye(IDye dye)
        {
            this.dyes.Add(dye);
        }

        public virtual void Work() { }
    }
}
