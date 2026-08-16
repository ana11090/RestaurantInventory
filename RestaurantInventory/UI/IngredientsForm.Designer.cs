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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ingredientTxt = new System.Windows.Forms.TextBox();
            this.typeIngredientTxt = new System.Windows.Forms.TextBox();
            this.weightNum = new System.Windows.Forms.NumericUpDown();
            this.kcalNum = new System.Windows.Forms.NumericUpDown();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.addInventoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredient:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight (g):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kcal (per 100g):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price (per 100g):";
            // 
            // ingredientTxt
            // 
            this.ingredientTxt.Location = new System.Drawing.Point(178, 33);
            this.ingredientTxt.Name = "ingredientTxt";
            this.ingredientTxt.Size = new System.Drawing.Size(210, 30);
            this.ingredientTxt.TabIndex = 5;
            // 
            // typeIngredientTxt
            // 
            this.typeIngredientTxt.Location = new System.Drawing.Point(178, 74);
            this.typeIngredientTxt.Name = "typeIngredientTxt";
            this.typeIngredientTxt.Size = new System.Drawing.Size(210, 30);
            this.typeIngredientTxt.TabIndex = 6;
            // 
            // weightNum
            // 
            this.weightNum.Location = new System.Drawing.Point(178, 114);
            this.weightNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.weightNum.Name = "weightNum";
            this.weightNum.Size = new System.Drawing.Size(210, 30);
            this.weightNum.TabIndex = 7;
            // 
            // kcalNum
            // 
            this.kcalNum.Location = new System.Drawing.Point(178, 157);
            this.kcalNum.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.kcalNum.Name = "kcalNum";
            this.kcalNum.Size = new System.Drawing.Size(210, 30);
            this.kcalNum.TabIndex = 8;
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Location = new System.Drawing.Point(178, 199);
            this.priceNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(210, 30);
            this.priceNum.TabIndex = 9;
            // 
            // addInventoryBtn
            // 
            this.addInventoryBtn.Location = new System.Drawing.Point(178, 261);
            this.addInventoryBtn.Name = "addInventoryBtn";
            this.addInventoryBtn.Size = new System.Drawing.Size(210, 35);
            this.addInventoryBtn.TabIndex = 10;
            this.addInventoryBtn.Text = "Add ingredient";
            this.addInventoryBtn.UseVisualStyleBackColor = true;
            this.addInventoryBtn.Click += new System.EventHandler(this.addInventoryBtn_Click);
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 339);
            this.Controls.Add(this.addInventoryBtn);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.kcalNum);
            this.Controls.Add(this.weightNum);
            this.Controls.Add(this.typeIngredientTxt);
            this.Controls.Add(this.ingredientTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IngredientsForm";
            this.Text = "Add ingredients to inventory";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}