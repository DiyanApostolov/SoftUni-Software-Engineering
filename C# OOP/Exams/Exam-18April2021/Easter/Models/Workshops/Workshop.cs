namespace Easter.Models.Workshops
{
    using System.Linq;
    using Easter.Models.Bunnies.Contracts;
    using Easter.Models.Eggs.Contracts;
    using Easter.Models.Workshops.Contracts;

    public class Workshop : IWorkshop
    {
        public void Color(IEgg egg, IBunny bunny)
        {
            while (!egg.IsDone())
            {
                if (bunny.Energy == 0)
                {
                    break;
                }

                if (bunny.Dyes.All(x => x.IsFinished()))
                {
                    break;
                }

                egg.GetColored();
                bunny.Work();
            }
        }
    }
}
