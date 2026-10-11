using Dapper;
using DataAccessLayer.Contracts;
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml.Linq; 

namespace DataAccessLayer.Repostitories
{
    public class RecipeTypeRepostorycs : IRecipeTypeRepostorycs
    {
        public event Action<string> OnError;

        public async Task AddRecipeType(RecipeType recipeType)
        { 
            try
            {
                string connectionString = ConnectionHelper.GetConnectionStringSettings;

                string query = @"insert into RecipeTypes( name) 
                        values ( @name)";

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {

                    await connection.ExecuteAsync(query, recipeType);
                    //    connection.Execute(@"dbo.InsertIngredientProcedure @ingredientName, 
                    //ingredientType, @weight, @kcalPer100g, @price", ingredient); //using stored procedure
                }
            } 
            catch (Exception ex)
            {
                string errorMessage = "An error ocured while adding the recipe type. The recipe type wasn't added!";
                Logger.LogError(errorMessage, ex);
                ErrorOccured(errorMessage);

            }
        }

        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }

        public async Task<List<RecipeType>> GetRecipeType()
        {
            try
            {
                string connectionString = ConnectionHelper.GetConnectionStringSettings;
                string query = @"select * from RecipeTypes";

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    // Pass the value for @name as a Dapper parameter (safe against SQL injection).
                    // The % wildcards go in the value, so LIKE matches the name anywhere in the string.

                    //for sync methods
                    // List<Ingredient> ingredients = connection.Query<Ingredient>(query, new { name = $"%{name}%" }).ToList();

                    //for async methods
                    var ingredients = await connection.QueryAsync<RecipeType>(query);
                    return ingredients.ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error ocured while getting the ingredient!";
                Logger.LogError(errorMessage, ex);
                ErrorOccured(errorMessage);

                return new List<RecipeType>();
            }
        }
    }
}
