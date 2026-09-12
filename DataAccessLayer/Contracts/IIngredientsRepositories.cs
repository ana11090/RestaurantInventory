using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer.Contracts
{
    public interface IIngredientsRepositories
    {
        public Task AddIngredient(Ingredient ingredient);

        public Task<List<Ingredient>> GetIngredients(string? name);
        public Task DeleteIngredient(Ingredient ingredient);

    }
}
