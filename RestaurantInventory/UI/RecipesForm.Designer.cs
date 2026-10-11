namespace RestaurantInventory.UI
{
    partial class RecipesForm
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
            dgvIngredients = new DataGridView();
            lbName = new Label();
            lbType = new Label();
            lbDescription = new Label();
            lbImage = new Label();
            cmbRecipeFilter = new ComboBox();
            cmbTypeRecipe = new ComboBox();
            picImage = new PictureBox();
            rtbDecriptionRecipe = new RichTextBox();
            txtNameRecipe = new TextBox();
            btnAddRecipe = new Button();
            btnRecipeIngredients = new Button();
            btnClearAllFields = new Button();
            btnAddRecipeType = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // dgvIngredients
            // 
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(9, 70);
            dgvIngredients.Margin = new Padding(2, 3, 2, 3);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.RowHeadersWidth = 51;
            dgvIngredients.Size = new Size(594, 473);
            dgvIngredients.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(642, 70);
            lbName.Margin = new Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(64, 28);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(642, 117);
            lbType.Margin = new Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(53, 28);
            lbType.TabIndex = 2;
            lbType.Text = "Type";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(642, 169);
            lbDescription.Margin = new Padding(2, 0, 2, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(112, 28);
            lbDescription.TabIndex = 3;
            lbDescription.Text = "Description";
            // 
            // lbImage
            // 
            lbImage.AutoSize = true;
            lbImage.Location = new Point(640, 274);
            lbImage.Margin = new Padding(2, 0, 2, 0);
            lbImage.Name = "lbImage";
            lbImage.Size = new Size(66, 28);
            lbImage.TabIndex = 4;
            lbImage.Text = "Image";
            // 
            // cmbRecipeFilter
            // 
            cmbRecipeFilter.FormattingEnabled = true;
            cmbRecipeFilter.Location = new Point(20, 22);
            cmbRecipeFilter.Margin = new Padding(2, 3, 2, 3);
            cmbRecipeFilter.Name = "cmbRecipeFilter";
            cmbRecipeFilter.Size = new Size(589, 36);
            cmbRecipeFilter.TabIndex = 5;
            // 
            // cmbTypeRecipe
            // 
            cmbTypeRecipe.FormattingEnabled = true;
            cmbTypeRecipe.Location = new Point(764, 113);
            cmbTypeRecipe.Margin = new Padding(2, 3, 2, 3);
            cmbTypeRecipe.Name = "cmbTypeRecipe";
            cmbTypeRecipe.Size = new Size(111, 36);
            cmbTypeRecipe.TabIndex = 6;
            // 
            // picImage
            // 
            picImage.Location = new Point(761, 274);
            picImage.Margin = new Padding(2, 3, 2, 3);
            picImage.Name = "picImage";
            picImage.Size = new Size(230, 128);
            picImage.TabIndex = 7;
            picImage.TabStop = false;
            // 
            // rtbDecriptionRecipe
            // 
            rtbDecriptionRecipe.Location = new Point(761, 155);
            rtbDecriptionRecipe.Margin = new Padding(2, 3, 2, 3);
            rtbDecriptionRecipe.Name = "rtbDecriptionRecipe";
            rtbDecriptionRecipe.Size = new Size(237, 102);
            rtbDecriptionRecipe.TabIndex = 8;
            rtbDecriptionRecipe.Text = "";
            // 
            // txtNameRecipe
            // 
            txtNameRecipe.Location = new Point(761, 64);
            txtNameRecipe.Name = "txtNameRecipe";
            txtNameRecipe.Size = new Size(230, 34);
            txtNameRecipe.TabIndex = 9;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(642, 412);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(349, 42);
            btnAddRecipe.TabIndex = 10;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // btnRecipeIngredients
            // 
            btnRecipeIngredients.Location = new Point(642, 460);
            btnRecipeIngredients.Name = "btnRecipeIngredients";
            btnRecipeIngredients.Size = new Size(349, 42);
            btnRecipeIngredients.TabIndex = 11;
            btnRecipeIngredients.Text = "Recipe Ingredients";
            btnRecipeIngredients.UseVisualStyleBackColor = true;
            // 
            // btnClearAllFields
            // 
            btnClearAllFields.Location = new Point(640, 508);
            btnClearAllFields.Name = "btnClearAllFields";
            btnClearAllFields.Size = new Size(349, 42);
            btnClearAllFields.TabIndex = 12;
            btnClearAllFields.Text = "Clear All Fields";
            btnClearAllFields.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipeType
            // 
            btnAddRecipeType.Location = new Point(895, 113);
            btnAddRecipeType.Name = "btnAddRecipeType";
            btnAddRecipeType.Size = new Size(94, 33);
            btnAddRecipeType.TabIndex = 13;
            btnAddRecipeType.Text = "Add";
            btnAddRecipeType.UseVisualStyleBackColor = true;
            btnAddRecipeType.Click += btnAddRecipeType_Click;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 555);
            Controls.Add(btnAddRecipeType);
            Controls.Add(btnClearAllFields);
            Controls.Add(btnRecipeIngredients);
            Controls.Add(btnAddRecipe);
            Controls.Add(txtNameRecipe);
            Controls.Add(rtbDecriptionRecipe);
            Controls.Add(picImage);
            Controls.Add(cmbTypeRecipe);
            Controls.Add(cmbRecipeFilter);
            Controls.Add(lbImage);
            Controls.Add(lbDescription);
            Controls.Add(lbType);
            Controls.Add(lbName);
            Controls.Add(dgvIngredients);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIngredients;
        private Label lbName;
        private Label lbType;
        private Label lbDescription;
        private Label lbImage;
        private ComboBox cmbRecipeFilter;
        private ComboBox cmbTypeRecipe;
        private PictureBox picImage;
        private RichTextBox rtbDecriptionRecipe;
        private TextBox txtNameRecipe;
        private Button btnAddRecipe;
        private Button btnRecipeIngredients;
        private Button btnClearAllFields;
        private Button btnAddRecipeType;
    }
}