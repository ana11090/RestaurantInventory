using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using DomainModel.Model;
using System.Data.SqlClient;
using Dapper;
namespace DataAccessLayer
{
    public class IngredientsDataAccess
    {
        public void AddIngredient(Ingredient ingredient )
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["RestaurantConnectionString"].ConnectionString;

            string query = @"insert into Ingredients( ingredientName, 
                        ingredientType, weight, kcalPer100g, price) 
                        values ( @ingredientName, @ingredientType, @weight, @kcalPer100g, @price)";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                connection.Execute(query, ingredient);
            //    connection.Execute(@"dbo.InsertIngredientProcedure @ingredientName, 
            //ingredientType, @weight, @kcalPer100g, @price", ingredient);
            }

        }

        public List<Ingredient> GetIngredients()
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["RestaurantConnectionString"].ConnectionString;

            string query = @"select * from Ingredients";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                List<Ingredient> ingredients = connection.Query<Ingredient>(query).ToList();
                return ingredients;
            }

        }

    }
}
