using DataAccessLayer; 
using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Contracts;

namespace RestaurantInventory.UI
{
    public partial class IngredientsForm : Form
    {
        readonly IIngredientsRepositories _ingredientsRepository; //db access
        public IngredientsForm(IIngredientsRepositories ingredientsRepository)
        {
            InitializeComponent();
            _ingredientsRepository = ingredientsRepository;
        }

        //private void addInventoryBtn_Click(object sender, EventArgs e)
        //{
        //string message = ingredientTxt.Text + "\n"
        //    + typeIngredientTxt.Text + "\n"
        //    + weightNum.Value + "\n"
        //    + kcalNum.Value + "\n"
        //    + priceNum.Value;


        //Ingredient ingredient = new Ingredient
        //{
        //    IngredientName = ingredientTxt.Text,
        //    IngredientType = typeIngredientTxt.Text,
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
        //    List<Ingredient> ingredients = new List<Ingredient>();

        //    Ingredient i1 = new Ingredient
        //    {
        //        IngredientName = "Apple",
        //        IngredientType = "Fruit",
        //        Weight = 100,
        //        Kcal = 80,
        //        Price = 0.3m
        //    };
        //    Ingredient i2 = new Ingredient
        //    {
        //        IngredientName = "Banana",
        //        IngredientType = "Fruit",
        //        Weight = 100,
        //        Kcal = 80,
        //        Price = 0.3m
        //    };
        //    Ingredient i3 = new Ingredient
        //    {
        //        IngredientName = "Pear",
        //        IngredientType = "Fruit",
        //        Weight = 100,
        //        Kcal = 80,
        //        Price = 0.3m
        //    };

        //    ingredients.Add(i1);
        //    ingredients.Add(i2);
        //    ingredients.Add(i3);

        //    string message = "";
        //    //foreach (Ingredient i in ingredients)
        //    //    message += $@"
        //    //      {i.IngredientName} ";

        //    ingredients.ForEach( x =>  message += x.IngredientName );

        //    MessageBox.Show(message);
        //}

        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient(ingredientTxt.Text, typeIngredientTxt.Text,
                 weightNum.Value, kcalNum.Value, priceNum.Value);
            //ingredient.IngredientName = ingredientTxt.Text;
            //ingredient.IngredientType = typeIngredientTxt.Text;
            //ingredient.Weight = weightNum.Value;
            //ingredient.KcalPer100g = kcalNum.Value;
            //ingredient.Price = priceNum.Value;

            _ingredientsRepository.AddIngredient(ingredient);
            ClearAllFields();
            RefreshIngredientsGrid();
        }

        private void ClearAllFields()
        {
            ingredientTxt.Text = default; //same as null
            typeIngredientTxt.Text = string.Empty;
            weightNum.Value = default; //same as 0
            kcalNum.Value = 0;
            priceNum.Value = 0;
        }

        private void RefreshIngredientsGrid()
        {
            List<Ingredient> ingredients = _ingredientsRepository.GetIngredients(txtSearch.Text);
            ingredientsGrid.DataSource = ingredients;
        }
        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshIngredientsGrid();
            CustomizeGridAppearence();
        }

        private void CustomizeGridAppearence()
        {
            ingredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "IngredientName", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "IngredientType", HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "Price", HeaderText = "Price (100g)" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "KcalPer100g", HeaderText = "Kcal (100g)" };

            ingredientsGrid.Columns.Clear();
            ingredientsGrid.Columns.AddRange(columns);
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshIngredientsGrid();
        } 
    }


}
