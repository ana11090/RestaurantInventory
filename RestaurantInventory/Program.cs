using DataAccessLayer;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repostitories;
using RestaurantInventory.UI;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

            //Depency Injection - database - from strach
            //IIngredientsRepositories ingredientsRepository = null;
            //if (ConfigurationManager.AppSettings["repositoryType"] == "txt")
            //    ingredientsRepository = new IngredientsTxtRepository();
            //else
            //    ingredientsRepository = new IngredientsSqlRepository();
            //Application.Run(new IngredientsForm(ingredientsRepository));

            ServiceCollection services = ConfigureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            var startForm = serviceProvider.GetRequiredService<IngredientsForm>();
            Application.Run(startForm);
        }

        static ServiceCollection ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            if (ConfigurationManager.AppSettings["repositoryType"] == "txt")
                services.AddTransient<IIngredientsRepositories>(_ => new IngredientsTxtRepository());
            else
                services.AddTransient<IIngredientsRepositories>(_ => new IngredientsSqlRepository());

            services.AddTransient<IngredientsForm>();

            return services;

        }

    }
}