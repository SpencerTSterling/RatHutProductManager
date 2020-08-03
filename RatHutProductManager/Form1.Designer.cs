using System.Windows.Forms;
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
            this.SuspendLayout();
            // 
            // LbProducts
            // 
            this.LbProducts.FormattingEnabled = true;
            this.LbProducts.Location = new System.Drawing.Point(12, 29);
            this.LbProducts.Name = "LbProducts";
            this.LbProducts.Size = new System.Drawing.Size(137, 186);
            this.LbProducts.TabIndex = 0;
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
            this.BtnAddProduct.Location = new System.Drawing.Point(156, 29);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(105, 40);
            this.BtnAddProduct.TabIndex = 2;
            this.BtnAddProduct.Text = "Add Product";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.Location = new System.Drawing.Point(155, 75);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(105, 40);
            this.BtnUpdateProduct.TabIndex = 3;
            this.BtnUpdateProduct.Text = "Update Product";
            this.BtnUpdateProduct.UseVisualStyleBackColor = true;
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Location = new System.Drawing.Point(156, 121);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(105, 40);
            this.BtnDeleteProduct.TabIndex = 4;
            this.BtnDeleteProduct.Text = "Delete Product";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 234);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LbProducts;
        private Label label1;
        private Button BtnAddProduct;
        private Button BtnUpdateProduct;
        private Button BtnDeleteProduct;
    }
}

