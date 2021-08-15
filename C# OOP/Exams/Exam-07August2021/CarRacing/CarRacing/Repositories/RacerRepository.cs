namespace CarRacing.Repositories
{
    using CarRacing.Models.Racers.Contracts;
    using CarRacing.Repositories.Contracts;
    using CarRacing.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> racers;

        public RacerRepository()
        {
            this.racers = new List<IRacer>();
            this.Models = new List<IRacer>();
        }

        public IReadOnlyCollection<IRacer> Models { get; private set; }

    public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository);
            }

            this.racers.Add(model);

            this.Models = this.racers;
        }

        public IRacer FindBy(string property)
        {
            return this.Models.FirstOrDefault(r => r.Username == property);
        }

        public bool Remove(IRacer model)
        {
            if (this.racers.Contains(model))
            {
                this.racers.Remove(model);

                this.Models = this.racers;

                return true;
            }

            return false;
        }
    }
}
