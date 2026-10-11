namespace RestaurantInventory.UI
{
    partial class RecipeTypesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbRecipeType = new Label();
            txtNewTypeRecipe = new TextBox();
            btnAddRecipeTypes = new Button();
            lstRecipeTypes = new ListBox();
            SuspendLayout();
            // 
            // lbRecipeType
            // 
            lbRecipeType.AutoSize = true;
            lbRecipeType.Location = new Point(25, 33);
            lbRecipeType.Name = "lbRecipeType";
            lbRecipeType.Size = new Size(133, 31);
            lbRecipeType.TabIndex = 0;
            lbRecipeType.Text = "Recipe type";
            // 
            // txtNewTypeRecipe
            // 
            txtNewTypeRecipe.Location = new Point(164, 30);
            txtNewTypeRecipe.Name = "txtNewTypeRecipe";
            txtNewTypeRecipe.Size = new Size(163, 38);
            txtNewTypeRecipe.TabIndex = 1;
            // 
            // btnAddRecipeTypes
            // 
            btnAddRecipeTypes.Location = new Point(25, 239);
            btnAddRecipeTypes.Name = "btnAddRecipeTypes";
            btnAddRecipeTypes.Size = new Size(302, 44);
            btnAddRecipeTypes.TabIndex = 2;
            btnAddRecipeTypes.Text = "Add";
            btnAddRecipeTypes.UseVisualStyleBackColor = true;
            btnAddRecipeTypes.Click += btnAddRecipeTypes_Click;
            // 
            // lstRecipeTypes
            // 
            lstRecipeTypes.FormattingEnabled = true;
            lstRecipeTypes.Location = new Point(25, 89);
            lstRecipeTypes.Name = "lstRecipeTypes";
            lstRecipeTypes.Size = new Size(302, 128);
            lstRecipeTypes.TabIndex = 3;
            // 
            // RecipeTypesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 318);
            Controls.Add(lstRecipeTypes);
            Controls.Add(btnAddRecipeTypes);
            Controls.Add(txtNewTypeRecipe);
            Controls.Add(lbRecipeType);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "RecipeTypesForm";
            Text = "RecipeTypesForm";
            Load += RecipeTypesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRecipeType;
        private TextBox txtNewTypeRecipe;
        private Button btnAddRecipeTypes;
        private ListBox lstRecipeTypes;
    }
}