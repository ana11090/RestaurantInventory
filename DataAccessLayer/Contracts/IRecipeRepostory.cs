using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CustomQueryResults;

namespace DataAccessLayer.Contracts
{
    public interface IRecipeRepostory
    {
        public event Action<string> OnError;
        public Task AddRecipe(Recipe recipe); 
        public Task<List<RecipeWithType>> GetRecipes(); 
        public Task DeleteRecipe(int Id);
        public Task EditRecipe(Recipe recipe);
    }
}
