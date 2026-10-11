using DataAccessLayer.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantInventory.UI
{
    public partial class RecipesForm : Form
    {
        private readonly IRecipeTypeRepostorycs _recipeTypeRepostorycs;
        private readonly IServiceProvider _serviceProvider;
        public RecipesForm(IRecipeTypeRepostorycs recipeTypeRepostorycs, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _recipeTypeRepostorycs = recipeTypeRepostorycs;
            _serviceProvider = serviceProvider;
        }

        private async Task RefreshRecipeTypes()
        {
            cmbTypeRecipe.DataSource = await _recipeTypeRepostorycs.GetRecipeType();
            cmbTypeRecipe.DisplayMember = "Name"; //display only Name, not Id too

        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            RefreshRecipeTypes();
        }

        private void btnAddRecipeType_Click(object sender, EventArgs e)
        {
            RecipeTypesForm recipeTypesForm = _serviceProvider.GetRequiredService<RecipeTypesForm>();
            recipeTypesForm.ShowDialog();
        }
    }
}
