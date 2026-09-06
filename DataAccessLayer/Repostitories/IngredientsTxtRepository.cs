using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Contracts;

namespace DataAccessLayer.Repostitories
{
    public class IngredientsTxtRepository : IIngredientsRepositories
    {
        string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "IngredientsStorage.txt");
        public void AddIngredient(Ingredient ingredient)
        {
            int id = Math.Abs(Guid.NewGuid().GetHashCode());

            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine(@$"{id}|{ingredient.IngredientName}
                |{ingredient.Weight}|{ingredient.KcalPer100g}|
                {ingredient.Price}|{ingredient.IngredientType}");
            }
        }

        public List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (StreamReader sr = File.OpenText(_filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split('|');

                    Ingredient ingredient = new Ingredient();
                    ingredient.Id = int.Parse(values[0]);
                    ingredient.IngredientName = values[1];
                    ingredient.Weight = decimal.Parse(values[2]);
                    ingredient.KcalPer100g = decimal.Parse(values[3]);
                    ingredient.Price = decimal.Parse(values[4]);
                    ingredient.IngredientType = values[5];

                    ingredients.Add(ingredient);
                }
            }
            return ingredients;
        }
    }
}