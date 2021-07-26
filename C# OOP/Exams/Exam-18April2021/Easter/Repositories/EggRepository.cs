namespace Easter.Repositories
{
    using System.Linq;
    using System.Collections.Generic;
    using Easter.Models.Eggs.Contracts;
    using Easter.Repositories.Contracts;

    public class EggRepository : IRepository<IEgg>
    {
        private List<IEgg> eggs;

        public EggRepository()
        {
            this.eggs = new List<IEgg>();
        }

        public IReadOnlyCollection<IEgg> Models { get; private set; } = new List<IEgg>();

        public void Add(IEgg model)
        {
            this.eggs.Add(model);

            this.Models = eggs;
        }

        public IEgg FindByName(string name)
        {
            return eggs.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IEgg model)
        {
            if (eggs.Contains(model))
            {
                eggs.Remove(model);

                Models = eggs;

                return true;
            }

            return false;
        }
    }
}
