using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Model;

namespace RestaurantInventory.UI
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            //string message = ingredientTxt.Text + "\n"
            //    + typeIngredientTxt.Text + "\n"
            //    + weightNum.Value + "\n"
            //    + kcalNum.Value + "\n"
            //    + priceNum.Value;


            //Ingredient ingredient = new Ingredient
            //{
            //    IngredientName = ingredientTxt.Text,
            //    IngredientType = ingredientTxt.Text,
            //    Weight = weightNum.Value,
            //    Kcal = kcalNum.Value,
            //    Price = priceNum.Value

            //};
            //string message = $@"
            //    {ingredient.IngredientName}
            //    {ingredient.IngredientType}
            //    {ingredient.Weight}
            //    {ingredient.Kcal}
            //    {ingredient.Price}";
            List<Ingredient> ingredients = new List<Ingredient>();

            Ingredient i1 = new Ingredient
            {
                IngredientName = "Apple",
                IngredientType = "Fruit",
                Weight = 100,
                Kcal = 80,
                Price = 0.3m
            };
            Ingredient i2 = new Ingredient
            {
                IngredientName = "Banana",
                IngredientType = "Fruit",
                Weight = 100,
                Kcal = 80,
                Price = 0.3m
            };
            Ingredient i3 = new Ingredient
            {
                IngredientName = "Pear",
                IngredientType = "Fruit",
                Weight = 100,
                Kcal = 80,
                Price = 0.3m
            };

            ingredients.Add(i1);
            ingredients.Add(i2);
            ingredients.Add(i3);

            string message = "";
            //foreach (Ingredient i in ingredients)
            //    message += $@"
            //      {i.IngredientName} ";

            ingredients.ForEach( x =>  message += x.IngredientName );

            MessageBox.Show(message);
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {

        }
    }

   
}
