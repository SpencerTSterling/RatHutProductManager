﻿using System.Windows.Forms;
namespace RatHutProductManager
{
    partial class Form1 : Form
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
            this.LbProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnUpdateProduct = new System.Windows.Forms.Button();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.DdSortByCondition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DdSortByCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LbProducts
            // 
            this.LbProducts.FormattingEnabled = true;
            this.LbProducts.Location = new System.Drawing.Point(12, 29);
            this.LbProducts.Name = "LbProducts";
            this.LbProducts.Size = new System.Drawing.Size(172, 251);
            this.LbProducts.TabIndex = 0;
            this.LbProducts.SelectedIndexChanged += new System.EventHandler(this.LbProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(193, 140);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(105, 40);
            this.BtnAddProduct.TabIndex = 2;
            this.BtnAddProduct.Text = "Add Product";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.Location = new System.Drawing.Point(193, 186);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(105, 40);
            this.BtnUpdateProduct.TabIndex = 3;
            this.BtnUpdateProduct.Text = "Update Product";
            this.BtnUpdateProduct.UseVisualStyleBackColor = true;
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Location = new System.Drawing.Point(193, 232);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(105, 40);
            this.BtnDeleteProduct.TabIndex = 4;
            this.BtnDeleteProduct.Text = "Delete Product";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // DdSortByCondition
            // 
            this.DdSortByCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdSortByCondition.FormattingEnabled = true;
            this.DdSortByCondition.Items.AddRange(new object[] {
            "Oldest to Newest products",
            "Newest to Oldest products",
            "Lowest to highest price",
            "Highest to lowest price",
            "Alphabetical"});
            this.DdSortByCondition.Location = new System.Drawing.Point(193, 45);
            this.DdSortByCondition.Name = "DdSortByCondition";
            this.DdSortByCondition.Size = new System.Drawing.Size(160, 21);
            this.DdSortByCondition.TabIndex = 5;
            this.DdSortByCondition.SelectedIndexChanged += new System.EventHandler(this.DdSortByCondition_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sort By Condition:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sort By Category:";
            // 
            // DdSortByCategory
            // 
            this.DdSortByCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdSortByCategory.FormattingEnabled = true;
            this.DdSortByCategory.Items.AddRange(new object[] {
            "All",
            "Burgers",
            "Chicken/Sandwiches",
            "Breakfast",
            "Sides",
            "Dessert",
            "Misc"});
            this.DdSortByCategory.Location = new System.Drawing.Point(193, 90);
            this.DdSortByCategory.Name = "DdSortByCategory";
            this.DdSortByCategory.Size = new System.Drawing.Size(160, 21);
            this.DdSortByCategory.TabIndex = 8;
            this.DdSortByCategory.SelectedIndexChanged += new System.EventHandler(this.DdSortByCategory_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 284);
            this.Controls.Add(this.DdSortByCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DdSortByCondition);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LbProducts;
        private Label label1;
        private Button BtnAddProduct;
        private Button BtnUpdateProduct;
        private Button BtnDeleteProduct;
        private ComboBox DdSortByCondition;
        private Label label2;
        private Label label3;
        private ComboBox DdSortByCategory;
    }
}

