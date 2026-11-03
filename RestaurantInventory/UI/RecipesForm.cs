using DataAccessLayer.Contracts;
using DataAccessLayer.CustomQueryResults;
using DomainModel.Model;
using Microsoft.Extensions.DependencyInjection;
using RestaurantInventory.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace RestaurantInventory.UI
{
    public partial class RecipesForm : Form
    {
        private readonly IRecipeTypeRepostory _recipeTypeRepostorycs;

        private readonly IRecipeRepostory _recipeRepostorycs;
        private readonly IServiceProvider _serviceProvider;
        private string _placeholderImagePath
        {
            get
            {
                var executingAssemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                return Path.Combine(executingAssemblyLocation, "Assets", "recipe_image_default.png");
            }
        }

        private bool _isUserImageAdded = false;
        private int _recipeToEditId;
        public RecipesForm(IRecipeRepostory recipeRepostorycs, IRecipeTypeRepostory recipeTypeRepostorycs, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _recipeRepostorycs = recipeRepostorycs;
            _recipeTypeRepostorycs = recipeTypeRepostorycs;
            _serviceProvider = serviceProvider;

            _recipeRepostorycs.OnError += OnErrorOcured;

        }

        private void OnErrorOcured(string message)
        {
            MessageBox.Show(message);
        }

        private async Task RefreshRecipeTypes()
        {
            List<RecipeType> recipeTypes = await _recipeTypeRepostorycs.GetRecipeType();
            cmbTypeRecipe.DataSource = recipeTypes;
            cmbTypeRecipe.DisplayMember = "Name"; //display only Name, not Id too

            List<RecipeType> filterRecipeTypes = recipeTypes;
            filterRecipeTypes.Add(new RecipeType("All types", 0));
            cmbRecipeFilter.DataSource = recipeTypes;
            cmbRecipeFilter.DisplayMember = "Name";


        }
        private async void RefreshRecipesGrid()
        {
            dgvIngredients.DataSource = await _recipeRepostorycs.GetRecipes();
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            btnEditRecipe.Visible = false;
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ClearAllFields();
            RefreshRecipeTypes();
            RefreshRecipesGrid();
            CustomizeGridAppearance();
        }

        private void btnAddRecipeType_Click(object sender, EventArgs e)
        {
            RecipeTypesForm recipeTypesForm = _serviceProvider.GetRequiredService<RecipeTypesForm>();
            //recipeTypesForm.FormClosed += OnRecipeTypeFormClosed;
            recipeTypesForm.FormClosed += (sender, e) => RefreshRecipeTypes();
            recipeTypesForm.ShowDialog();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;
            byte[] image = null;
            if (_isUserImageAdded)
                image = ImageHelper.ConvertToDbImage(picImage.ImageLocation);

            Recipe recipe = new Recipe(txtNameRecipe.Text,
                ((RecipeType)cmbTypeRecipe.SelectedItem).Id,
                rtbDecriptionRecipe.Text, image);

            _recipeRepostorycs.AddRecipe(recipe);
            ClearAllFields();
            RefreshRecipesGrid();
        }
        private void CustomizeGridAppearance()
        {
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvIngredients.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Description", HeaderText = "Description" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[4] = new DataGridViewButtonColumn()
            {
                Text = "Edit",
                Name = "EditBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            columns[5] = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                Name = "DeleteBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };

            dgvIngredients.RowHeadersVisible = false;
            dgvIngredients.Columns.Clear();
            dgvIngredients.Columns.AddRange(columns);
        }
        private void ClearAllFields()
        {
            txtNameRecipe.Text = string.Empty;
            rtbDecriptionRecipe.Text = string.Empty;
            picImage.ImageLocation = _placeholderImagePath;
            _isUserImageAdded = false;

        }
        private bool IsValid()
        {
            bool isValid = true;
            string message = "";

            if (string.IsNullOrEmpty(txtNameRecipe.Text))
            {
                isValid = false;
                message += "Please enter name.\n\n";
            }
            if (string.IsNullOrEmpty(rtbDecriptionRecipe.Text))
            {
                isValid = false;
                message += "Please enter description.\n\n";
            }

            if (!isValid)
                MessageBox.Show(message, "Form not valid!");

            return isValid;
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Please select an image",
                Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picImage.ImageLocation = openFileDialog.FileName;
                    _isUserImageAdded = true;
                }
            }
        }

        private void btnClearAllFields_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private async void dgvIngredients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvIngredients.CurrentCell is DataGridViewButtonCell)
            {
                RecipeWithType clickedRecipe = (RecipeWithType)dgvIngredients.Rows[e.RowIndex].DataBoundItem;

                if (dgvIngredients.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {
                    await _recipeRepostorycs.DeleteRecipe(clickedRecipe.Id);
                    RefreshRecipesGrid();
                }
                else if (dgvIngredients.CurrentCell.OwningColumn.Name == "EditBtn")
                {
                    FillFormForEdit(clickedRecipe);
                    btnEditRecipe.Visible = true;
                    _recipeToEditId = clickedRecipe.Id;
                }
            }
        }

        // get the combo box position of the recipe type, so it shows up selected when editing
        private int FindRecipeTypeIndex(int recipeTypeId)
        {
            List<RecipeType> allRecipeTypes = (List<RecipeType>)cmbTypeRecipe.DataSource;
            RecipeType matchingRecipeType = allRecipeTypes.FirstOrDefault(rt => rt.Id == recipeTypeId);
            return cmbTypeRecipe.Items.IndexOf(matchingRecipeType); // -1 if not found
        }
        private void FillFormForEdit(RecipeWithType clickedRecipe)
        {
            txtNameRecipe.Text = clickedRecipe.Name;
            rtbDecriptionRecipe.Text = clickedRecipe.Description;
            if (clickedRecipe.Image != null)
                picImage.Image = ImageHelper.ConvertFromDbImage(clickedRecipe.Image);
            else
                picImage.ImageLocation = _placeholderImagePath;

            cmbTypeRecipe.SelectedIndex = FindRecipeTypeIndex(clickedRecipe.RecipeTypeId);
        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            byte[] image = null;
            if (_isUserImageAdded)
                image = ImageHelper.ConvertToDbImage(picImage.ImageLocation);

            Recipe recipe = new Recipe(txtNameRecipe.Text,
                ((RecipeType)cmbTypeRecipe.SelectedItem).Id,
                rtbDecriptionRecipe.Text, image, _recipeToEditId);

            await _recipeRepostorycs.EditRecipe(recipe);
            ClearAllFields();
            RefreshRecipesGrid();
            btnEditRecipe.Visible = false;
        }

        private void cmbTypeRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //private void OnRecipeTypeFormClosed(object? sender, FormClosedEventArgs e)
        //{
        //    RefreshRecipeTypes();
        //}
    }
}
