namespace RestaurantInventory.UI
{
    partial class IngredientsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ingredientTxt = new TextBox();
            typeIngredientTxt = new TextBox();
            weightNum = new NumericUpDown();
            kcalNum = new NumericUpDown();
            priceNum = new NumericUpDown();
            addInventoryBtn = new Button();
            ingredientsGrid = new DataGridView();
            txtSearch = new TextBox();
            btnClearAllFields = new Button();
            ((System.ComponentModel.ISupportInitialize)weightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kcalNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 0;
            label1.Text = "Ingredient:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 82);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 1;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 122);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 2;
            label3.Text = "Weight (g):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 163);
            label4.Name = "label4";
            label4.Size = new Size(143, 22);
            label4.TabIndex = 3;
            label4.Text = "Kcal (per 100g):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 199);
            label5.Name = "label5";
            label5.Size = new Size(147, 22);
            label5.TabIndex = 4;
            label5.Text = "Price (per 100g):";
            // 
            // ingredientTxt
            // 
            ingredientTxt.Location = new Point(178, 33);
            ingredientTxt.Name = "ingredientTxt";
            ingredientTxt.Size = new Size(210, 30);
            ingredientTxt.TabIndex = 5;
            // 
            // typeIngredientTxt
            // 
            typeIngredientTxt.Location = new Point(178, 74);
            typeIngredientTxt.Name = "typeIngredientTxt";
            typeIngredientTxt.Size = new Size(210, 30);
            typeIngredientTxt.TabIndex = 6;
            // 
            // weightNum
            // 
            weightNum.Location = new Point(178, 114);
            weightNum.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            weightNum.Name = "weightNum";
            weightNum.Size = new Size(210, 30);
            weightNum.TabIndex = 7;
            // 
            // kcalNum
            // 
            kcalNum.Location = new Point(178, 157);
            kcalNum.Maximum = new decimal(new int[] { 1500, 0, 0, 0 });
            kcalNum.Name = "kcalNum";
            kcalNum.Size = new Size(210, 30);
            kcalNum.TabIndex = 8;
            // 
            // priceNum
            // 
            priceNum.DecimalPlaces = 2;
            priceNum.Location = new Point(178, 199);
            priceNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            priceNum.Name = "priceNum";
            priceNum.Size = new Size(210, 30);
            priceNum.TabIndex = 9;
            // 
            // addInventoryBtn
            // 
            addInventoryBtn.Location = new Point(178, 261);
            addInventoryBtn.Name = "addInventoryBtn";
            addInventoryBtn.Size = new Size(210, 35);
            addInventoryBtn.TabIndex = 10;
            addInventoryBtn.Text = "Add ingredient";
            addInventoryBtn.UseVisualStyleBackColor = true;
            addInventoryBtn.Click += addInventoryBtn_Click;
            // 
            // ingredientsGrid
            // 
            ingredientsGrid.ColumnHeadersHeight = 29;
            ingredientsGrid.Location = new Point(420, 82);
            ingredientsGrid.Name = "ingredientsGrid";
            ingredientsGrid.RowHeadersWidth = 51;
            ingredientsGrid.Size = new Size(446, 277);
            ingredientsGrid.TabIndex = 15;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(420, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type here the ingredient name...";
            txtSearch.Size = new Size(446, 30);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClearAllFields
            // 
            btnClearAllFields.Location = new Point(178, 312);
            btnClearAllFields.Name = "btnClearAllFields";
            btnClearAllFields.Size = new Size(210, 35);
            btnClearAllFields.TabIndex = 16;
            btnClearAllFields.Text = "Clear all fields";
            btnClearAllFields.UseVisualStyleBackColor = true;
            btnClearAllFields.Click += btnClearAllFields_Click;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 390);
            Controls.Add(btnClearAllFields);
            Controls.Add(txtSearch);
            Controls.Add(ingredientsGrid);
            Controls.Add(addInventoryBtn);
            Controls.Add(priceNum);
            Controls.Add(kcalNum);
            Controls.Add(weightNum);
            Controls.Add(typeIngredientTxt);
            Controls.Add(ingredientTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "IngredientsForm";
            Text = "Add ingredients to inventory";
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)weightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)kcalNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ingredientTxt;
        private System.Windows.Forms.TextBox typeIngredientTxt;
        private System.Windows.Forms.NumericUpDown weightNum;
        private System.Windows.Forms.NumericUpDown kcalNum;
        private System.Windows.Forms.NumericUpDown priceNum;
        private System.Windows.Forms.Button addInventoryBtn;
        private DataGridView ingredientsGrid;
        private TextBox txtSearch;
        private Button btnClearAllFields;
    }
}