namespace AquaShop.Repositories
{
    using System.Linq;
    using System.Collections.Generic;

    using AquaShop.Repositories.Contracts;
    using AquaShop.Models.Decorations.Contracts;

    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> decorations;

        public DecorationRepository()
        {
            this.decorations = new List<IDecoration>();
            this.Models = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models { get; private set; }

        public void Add(IDecoration model)
        {
            this.decorations.Add(model);

            this.Models = this.decorations;
        }

        public IDecoration FindByType(string type)
        {
            return this.Models.FirstOrDefault(x => x.GetType().Name == type);
        }

        public bool Remove(IDecoration model)
        {
            if (this.Models.Contains(model))
            {
                this.decorations.Remove(model);

                this.Models = this.decorations;

                return true;
            }

            return false;
        }
    }
}