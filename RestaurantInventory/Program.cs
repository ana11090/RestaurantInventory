using DataAccessLayer;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repostitories;
using RestaurantInventory.UI;
using System.Configuration;

namespace RestaurantInventory
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Depency Injection - database
            IIngredientsRepositories ingredientsRepository = null;

            if (ConfigurationManager.AppSettings["repositoryType"] == "txt")
                ingredientsRepository = new IngredientsTxtRepository();
            else
                ingredientsRepository = new IngredientsSqlRepository();

            Application.Run(new IngredientsForm(ingredientsRepository));
        }
    }
}