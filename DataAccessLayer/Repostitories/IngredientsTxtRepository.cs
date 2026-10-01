using DataAccessLayer.Contracts;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer.Repostitories
{
    public class IngredientsTxtRepository : IIngredientsRepositories
    {

        public event Action<string> OnError;
        string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "IngredientsStorage.txt");

        public async Task AddIngredient(Ingredient ingredient)
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    List<Ingredient> existingIngredients = await GetIngredients(null);

                    bool alreadyExists = existingIngredients.Any(i =>
                        i.IngredientName.Equals(ingredient.IngredientName, StringComparison.OrdinalIgnoreCase));

                    if (alreadyExists)
                    {
                        ErrorOccured("Thist ingredient alreay exist!");
                        return;
                    }
                }
                int id = Math.Abs(Guid.NewGuid().GetHashCode());

                using (StreamWriter sw = File.AppendText(_filePath))
                {
                    await sw.WriteLineAsync($"{id}|{ingredient.IngredientName}|{ingredient.Weight}|{ingredient.KcalPer100g}|{ingredient.Price}|{ingredient.IngredientType}");
                }
            }
            catch (IOException ex)
            {
                string errorMessage = "The ingredients file is in use or unavailable!";
                await Logger.LogError(errorMessage, ex);
                ErrorOccured(errorMessage);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occured while adding the ingredient. The ingredient wasn't added!";
                await Logger.LogError(errorMessage, ex);
                ErrorOccured(errorMessage);
            }
        }



        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }


        public async Task<List<Ingredient>> GetIngredients(string? name)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (StreamReader sr = File.OpenText(_filePath))
            {
                while (!sr.EndOfStream)
                {
                    //string line = await sr.ReadLine(); for sync methods
                    string line = await sr.ReadLineAsync(); //for async methods
                    string[] values = line.Split('|');

                    Ingredient ingredient = new Ingredient();
                    ingredient.Id = int.Parse(values[0]);
                    ingredient.IngredientName = values[1];
                    ingredient.Weight = decimal.Parse(values[2]);
                    ingredient.KcalPer100g = decimal.Parse(values[3]);
                    ingredient.Price = decimal.Parse(values[4]);
                    ingredient.IngredientType = values[5];

                    //check if the ingredient already extsts
                    if (string.IsNullOrEmpty(name) ||
                         ingredient.IngredientName.Contains(name, StringComparison.OrdinalIgnoreCase))
                        ingredients.Add(ingredient);
                }
            }
            return  ingredients;
        }


        public async Task DeleteIngredient(Ingredient ingredient)
        {
            string[] lines = await File.ReadAllLinesAsync(_filePath);

            // keep every line whose id is NOT the one deleted
            List<string> remaining = lines
                .Where(line => line.Split('|')[0] != ingredient.Id.ToString())
                .ToList();

            await File.WriteAllLinesAsync(_filePath, remaining);
        }

        public async Task EditIngredient(Ingredient ingredient)
        {
            string[] lines = await File.ReadAllLinesAsync(_filePath);

            // replace the line whose id matches, keep the rest unchanged
            List<string> updated = lines
                .Select(line => line.Split('|')[0] == ingredient.Id.ToString()
                    ? $"{ingredient.Id}|{ingredient.IngredientName}|{ingredient.Weight}|{ingredient.KcalPer100g}|{ingredient.Price}|{ingredient.IngredientType}"
                    : line)
                .ToList();

            await File.WriteAllLinesAsync(_filePath, updated);
        }
    }
}