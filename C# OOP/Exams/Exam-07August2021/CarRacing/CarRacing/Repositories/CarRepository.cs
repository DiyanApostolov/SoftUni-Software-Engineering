namespace CarRacing.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarRacing.Models.Cars.Contracts;
    using CarRacing.Repositories.Contracts;
    using CarRacing.Utilities.Messages;

    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> cars;

        public CarRepository()
        {
            this.cars = new List<ICar>();
            this.Models = new List<ICar>();
        }

        public IReadOnlyCollection<ICar> Models { get; private set; }

        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidRacerCar);
            }

            this.cars.Add(model);

            this.Models = this.cars;
        }

        public ICar FindBy(string property)
        {
            return this.Models.FirstOrDefault(c => c.VIN == property);
        }

        public bool Remove(ICar model)
        {
            if (this.cars.Contains(model))
            {
                this.cars.Remove(model);

                this.Models = this.cars;

                return true;
            }

            return false;
        }
    }
}
