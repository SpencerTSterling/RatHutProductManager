namespace RatHutProductManager
{
    partial class AddAndUpdateForm
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
            this.TxtProductTitle = new System.Windows.Forms.TextBox();
            this.TxtProductPrice = new System.Windows.Forms.TextBox();
            this.TxtProductDesc = new System.Windows.Forms.TextBox();
            this.GbProductCategory = new System.Windows.Forms.GroupBox();
            this.RbCatBurgers = new System.Windows.Forms.RadioButton();
            this.RbCatChickenSand = new System.Windows.Forms.RadioButton();
            this.RbCatBreakfast = new System.Windows.Forms.RadioButton();
            this.RbCatSides = new System.Windows.Forms.RadioButton();
            this.RbCatDessert = new System.Windows.Forms.RadioButton();
            this.RbCatMisc = new System.Windows.Forms.RadioButton();
            this.BtnAddToDB = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GbProductCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // TxtProductTitle
            // 
            this.TxtProductTitle.Location = new System.Drawing.Point(53, 13);
            this.TxtProductTitle.Name = "TxtProductTitle";
            this.TxtProductTitle.Size = new System.Drawing.Size(100, 20);
            this.TxtProductTitle.TabIndex = 3;
            // 
            // TxtProductPrice
            // 
            this.TxtProductPrice.Location = new System.Drawing.Point(53, 38);
            this.TxtProductPrice.Name = "TxtProductPrice";
            this.TxtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtProductPrice.TabIndex = 4;
            // 
            // TxtProductDesc
            // 
            this.TxtProductDesc.Location = new System.Drawing.Point(17, 83);
            this.TxtProductDesc.Multiline = true;
            this.TxtProductDesc.Name = "TxtProductDesc";
            this.TxtProductDesc.Size = new System.Drawing.Size(337, 83);
            this.TxtProductDesc.TabIndex = 5;
            // 
            // GbProductCategory
            // 
            this.GbProductCategory.Controls.Add(this.RbCatMisc);
            this.GbProductCategory.Controls.Add(this.RbCatDessert);
            this.GbProductCategory.Controls.Add(this.RbCatSides);
            this.GbProductCategory.Controls.Add(this.RbCatBreakfast);
            this.GbProductCategory.Controls.Add(this.RbCatChickenSand);
            this.GbProductCategory.Controls.Add(this.RbCatBurgers);
            this.GbProductCategory.Location = new System.Drawing.Point(17, 172);
            this.GbProductCategory.Name = "GbProductCategory";
            this.GbProductCategory.Size = new System.Drawing.Size(149, 160);
            this.GbProductCategory.TabIndex = 6;
            this.GbProductCategory.TabStop = false;
            this.GbProductCategory.Text = "Category";
            // 
            // RbCatBurgers
            // 
            this.RbCatBurgers.AutoSize = true;
            this.RbCatBurgers.Location = new System.Drawing.Point(6, 19);
            this.RbCatBurgers.Name = "RbCatBurgers";
            this.RbCatBurgers.Size = new System.Drawing.Size(61, 17);
            this.RbCatBurgers.TabIndex = 0;
            this.RbCatBurgers.TabStop = true;
            this.RbCatBurgers.Text = "Burgers";
            this.RbCatBurgers.UseVisualStyleBackColor = true;
            // 
            // RbCatChickenSand
            // 
            this.RbCatChickenSand.AutoSize = true;
            this.RbCatChickenSand.Location = new System.Drawing.Point(6, 42);
            this.RbCatChickenSand.Name = "RbCatChickenSand";
            this.RbCatChickenSand.Size = new System.Drawing.Size(133, 17);
            this.RbCatChickenSand.TabIndex = 1;
            this.RbCatChickenSand.TabStop = true;
            this.RbCatChickenSand.Text = "Chicken/Sandwhiches";
            this.RbCatChickenSand.UseVisualStyleBackColor = true;
            // 
            // RbCatBreakfast
            // 
            this.RbCatBreakfast.AutoSize = true;
            this.RbCatBreakfast.Location = new System.Drawing.Point(6, 65);
            this.RbCatBreakfast.Name = "RbCatBreakfast";
            this.RbCatBreakfast.Size = new System.Drawing.Size(70, 17);
            this.RbCatBreakfast.TabIndex = 2;
            this.RbCatBreakfast.TabStop = true;
            this.RbCatBreakfast.Text = "Breakfast";
            this.RbCatBreakfast.UseVisualStyleBackColor = true;
            // 
            // RbCatSides
            // 
            this.RbCatSides.AutoSize = true;
            this.RbCatSides.Location = new System.Drawing.Point(6, 88);
            this.RbCatSides.Name = "RbCatSides";
            this.RbCatSides.Size = new System.Drawing.Size(51, 17);
            this.RbCatSides.TabIndex = 3;
            this.RbCatSides.TabStop = true;
            this.RbCatSides.Text = "Sides";
            this.RbCatSides.UseVisualStyleBackColor = true;
            // 
            // RbCatDessert
            // 
            this.RbCatDessert.AutoSize = true;
            this.RbCatDessert.Location = new System.Drawing.Point(6, 111);
            this.RbCatDessert.Name = "RbCatDessert";
            this.RbCatDessert.Size = new System.Drawing.Size(61, 17);
            this.RbCatDessert.TabIndex = 4;
            this.RbCatDessert.TabStop = true;
            this.RbCatDessert.Text = "Dessert";
            this.RbCatDessert.UseVisualStyleBackColor = true;
            // 
            // RbCatMisc
            // 
            this.RbCatMisc.AutoSize = true;
            this.RbCatMisc.Location = new System.Drawing.Point(6, 134);
            this.RbCatMisc.Name = "RbCatMisc";
            this.RbCatMisc.Size = new System.Drawing.Size(47, 17);
            this.RbCatMisc.TabIndex = 5;
            this.RbCatMisc.TabStop = true;
            this.RbCatMisc.Text = "Misc";
            this.RbCatMisc.UseVisualStyleBackColor = true;
            // 
            // BtnAddToDB
            // 
            this.BtnAddToDB.Location = new System.Drawing.Point(159, 11);
            this.BtnAddToDB.Name = "BtnAddToDB";
            this.BtnAddToDB.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToDB.TabIndex = 7;
            this.BtnAddToDB.Text = "Add";
            this.BtnAddToDB.UseVisualStyleBackColor = true;
            this.BtnAddToDB.Click += new System.EventHandler(this.BtnAddToDB_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(159, 36);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddAndUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 355);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddToDB);
            this.Controls.Add(this.GbProductCategory);
            this.Controls.Add(this.TxtProductDesc);
            this.Controls.Add(this.TxtProductPrice);
            this.Controls.Add(this.TxtProductTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAndUpdateForm";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddAndUpdateForm_Load);
            this.GbProductCategory.ResumeLayout(false);
            this.GbProductCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProductTitle;
        private System.Windows.Forms.TextBox TxtProductPrice;
        private System.Windows.Forms.TextBox TxtProductDesc;
        private System.Windows.Forms.GroupBox GbProductCategory;
        private System.Windows.Forms.RadioButton RbCatMisc;
        private System.Windows.Forms.RadioButton RbCatDessert;
        private System.Windows.Forms.RadioButton RbCatSides;
        private System.Windows.Forms.RadioButton RbCatBreakfast;
        private System.Windows.Forms.RadioButton RbCatChickenSand;
        private System.Windows.Forms.RadioButton RbCatBurgers;
        private System.Windows.Forms.Button BtnAddToDB;
        private System.Windows.Forms.Button BtnCancel;
    }
}