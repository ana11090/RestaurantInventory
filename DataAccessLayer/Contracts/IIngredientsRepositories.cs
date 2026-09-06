using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer.Contracts
{
    public interface IIngredientsRepositories
    {
        public void AddIngredient(Ingredient ingredient);

        public List<Ingredient> GetIngredients();

    }
}
