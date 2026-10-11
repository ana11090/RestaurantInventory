using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer.Contracts;
using DomainModel.Model;

namespace RestaurantInventory.UI
{
    public partial class RecipeTypesForm : Form
    {
        private readonly IRecipeTypeRepostorycs _recipeTypeRepostorycs;
        public RecipeTypesForm(IRecipeTypeRepostorycs recipeTypeRepostorycs)
        {
            InitializeComponent();
            _recipeTypeRepostorycs = recipeTypeRepostorycs;
        }

        private void RecipeTypesForm_Load(object sender, EventArgs e)
        {
            RefreshTypeList();
        }

        private async Task RefreshTypeList()
        {
            lstRecipeTypes.DataSource = await _recipeTypeRepostorycs.GetRecipeType();
            lstRecipeTypes.DisplayMember = "Name";
        }

        private async void btnAddRecipeTypes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewTypeRecipe.Text))
                return;

            RecipeType newRecipeType = new RecipeType();
            newRecipeType.Name = txtNewTypeRecipe.Text;

            await _recipeTypeRepostorycs.AddRecipeType(newRecipeType);
            RefreshTypeList();
        }
    }
}
