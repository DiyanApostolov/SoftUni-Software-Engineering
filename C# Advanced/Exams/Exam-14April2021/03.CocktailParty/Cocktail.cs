using System.Collections.Generic;
using System.Linq;

namespace CocktailParty
{
    public class Cocktail
    {
        Dictionary<string, Ingredient> ingredients = new Dictionary<string, Ingredient>();
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        public void Add(Ingredient ingredient)
        {
            if (!ingredients.ContainsKey(ingredient.Name) 
                && ingredients.Count < Capacity)
            {
                ingredients.Add(ingredient.Name, ingredient);
            }
        }

        public bool Remove(string name)
        {
            if (ingredients.ContainsKey(name))
            {
                ingredients.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ingredient FindIngredient(string name)
        {
            if (ingredients.ContainsKey(name))
            {
                return ingredients[name];
            }

            return null;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            Ingredient output = ingredients.FirstOrDefault()
        }
    }
}
