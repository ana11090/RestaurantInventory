using Dapper;
using DataAccessLayer.Contracts;
using DataAccessLayer.CustomQueryResults;

using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer.Repostitories
{
    public class RecipeRepostory : IRecipeRepostory
    {
        public event Action<string> OnError;
        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }
        public async Task AddRecipe(Recipe recipe)
        {
            try
            {
                string connectionString = ConnectionHelper.GetConnectionStringSettings;

                string query = @"insert into Recipes( name, description, image, recipeTypeId)
                        values ( @RecipeName, @RecipeDescription, @RecipeImage, @RecipeTypeId)";

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {

                    await connection.ExecuteAsync(query, recipe);
                    //    connection.Execute(@"dbo.InsertIngredientProcedure @ingredientName, 
                    //ingredientType, @weight, @kcalPer100g, @price", ingredient); //using stored procedure
                }
            } 
            catch (Exception ex)
            {
                string errorMessage = "An error ocured while adding the recipe. The recipe wasn't added!";
                Logger.LogError(errorMessage, ex);
                ErrorOccured(errorMessage);

            }
        }


        public async Task<List<RecipeWithType>> GetRecipes()
        {
            try
            { 
                string query = @"select r.id as Id, r.name as Name, r.description as Description,
                        rt.name as Type, r.recipeTypeId as RecipeTypeId, r.image as Image
                 from Recipes as r join RecipeTypes as rt
                 on r.recipeTypeId = rt.id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionStringSettings))
                {
                    return (await connection.QueryAsync<RecipeWithType>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while getting recipes.";
                ErrorOccured(errorMessage);
                return new List<RecipeWithType>();
            }
        }

        public async Task DeleteRecipe(int Id)
        {
            try
            {
                string query = @$"delete from Recipes where Id={Id}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionStringSettings))
                {
                    await connection.ExecuteAsync(query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while deleting recipe.";
                ErrorOccured(errorMessage);
            }
        }
        public async Task EditRecipe(Recipe recipe)
        {
            try
            {
                string query = @"update Recipes
                                 set name         = @RecipeName,
                                     description  = @RecipeDescription," + 
                                     (recipe.RecipeImage!=null? "image=@RecipeImage," :"")+
                                     @"recipeTypeId = @RecipeTypeId
                                 where id = @Id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionStringSettings))
                {
                    await connection.ExecuteAsync(query, recipe);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while editing recipe.";
                ErrorOccured(errorMessage);
            }

        }
    }
}
