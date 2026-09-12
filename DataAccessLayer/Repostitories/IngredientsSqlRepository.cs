using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using DomainModel.Model;
using System.Data.SqlClient;
using Dapper;
using DataAccessLayer.Contracts;


namespace DataAccessLayer
{
    public class IngredientsSqlRepository : IIngredientsRepositories
    {
        public async Task AddIngredient(Ingredient ingredient )
        {
            string connectionString = ConnectionHelper.GetConnectionStringSettings;

            string query = @"insert into Ingredients( ingredientName, 
                        ingredientType, weight, kcalPer100g, price) 
                        values ( @ingredientName, @ingredientType, @weight, @kcalPer100g, @price)";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                await connection.ExecuteAsync(query, ingredient);
            //    connection.Execute(@"dbo.InsertIngredientProcedure @ingredientName, 
            //ingredientType, @weight, @kcalPer100g, @price", ingredient); //using stored procedure
            }

        }

        /// <summary>
        /// Returns ingredients from the database.
        /// If name contains text, returns only ingredients whose name contains it.
        /// If name is empty or null, returns all ingredients.
        /// </summary>
        /// <param name="name">
        /// The text to search for in the ingredient name.
        /// Empty or null = no filter, returns the full list.
        /// </param>
        /// <returns>The list of ingredients.</returns>
        public async Task<List<Ingredient>> GetIngredients(string? name="")
        {
            string connectionString = ConnectionHelper.GetConnectionStringSettings;
            string query = @"select * from Ingredients";
            if (!string.IsNullOrEmpty(name))
            {
                //query = query + $" where ingredientName like '%{name}%'";
                // Parametru Dapper (@name), nu concatenare — protejează împotriva SQL injection.
                query = query + " where ingredientName like @name";

            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                // Pass the value for @name as a Dapper parameter (safe against SQL injection).
                // The % wildcards go in the value, so LIKE matches the name anywhere in the string.

                //for sync methods
                // List<Ingredient> ingredients = connection.Query<Ingredient>(query, new { name = $"%{name}%" }).ToList();

                //for async methods
               var ingredients = await connection.QueryAsync<Ingredient>(query, new { name = $"%{name}%" });
                return  ingredients.ToList();
            }

        }


        public async Task DeleteIngredient(Ingredient ingredient)
        {
            string connectionString = ConnectionHelper.GetConnectionStringSettings;

            //string query = $"detele from Ingredients where id={ingredient.Id}";
            string query = $"delete from Ingredients where id=@Id";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                await connection.ExecuteAsync(query, ingredient);
                //    connection.Execute(@"dbo.InsertIngredientProcedure @ingredientName, 
                //ingredientType, @weight, @kcalPer100g, @price", ingredient); //using stored procedure
            }

        }
    }
}
