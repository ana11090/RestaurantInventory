using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Contracts
{
    public interface IRecipeTypeRepostorycs
    {
        public event Action<string> OnError;
        public Task AddRecipeType(RecipeType recipeType);
        public Task<List<RecipeType>> GetRecipeType();
    }
}
