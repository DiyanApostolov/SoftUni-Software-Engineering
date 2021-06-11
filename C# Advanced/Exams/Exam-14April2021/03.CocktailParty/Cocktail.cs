using System.Collections.Generic;

namespace CocktailParty
{
    public class Cocktail
    {
        List<Ingredient> ingredients;
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
    }
}
