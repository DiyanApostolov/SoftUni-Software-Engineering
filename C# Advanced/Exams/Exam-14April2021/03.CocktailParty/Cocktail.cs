using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        Dictionary<string, Ingredient> Ingredients = new Dictionary<string, Ingredient>();
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public int CurrentAlcoholLevel { get; set; } = 0;

        public void Add(Ingredient ingredient)
        {
            if (!Ingredients.ContainsKey(ingredient.Name) 
                && Ingredients.Count < Capacity
                && CurrentAlcoholLevel + ingredient.Alcohol <= MaxAlcoholLevel)
            {
                Ingredients.Add(ingredient.Name, ingredient);
                CurrentAlcoholLevel += ingredient.Alcohol;
            }
        }

        public bool Remove(string name)
        {
            if (Ingredients.ContainsKey(name))
            {
                CurrentAlcoholLevel -= Ingredients[name].Alcohol;
                Ingredients.Remove(name);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ingredient FindIngredient(string name)
        {
            if (Ingredients.ContainsKey(name))
            {
                return Ingredients[name];
            }

            return null;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            Ingredient mostAlcoholic = null;

            foreach (var item in Ingredients.OrderByDescending(i => i.Value.Alcohol))
            {
                mostAlcoholic = new Ingredient(item.Value.Name, item.Value.Alcohol, item.Value.Quantity);
                break;
            }

            return mostAlcoholic;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {this.CurrentAlcoholLevel}");
            foreach (var ingredient in Ingredients)
            {
                sb.AppendLine($"Ingredient: {ingredient.Value.Name}");
                sb.AppendLine($"Quantity: {ingredient.Value.Quantity}");
                sb.AppendLine($"Alcohol: {ingredient.Value.Alcohol}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
