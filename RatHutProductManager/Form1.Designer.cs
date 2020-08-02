namespace RatHutProductManager
{
    partial class Form1
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
            this.LblProductList = new System.Windows.Forms.Label();
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
            this.LbProducts.Size = new System.Drawing.Size(196, 147);
            this.LbProducts.TabIndex = 1;
            // 
            // LblProductList
            // 
            this.LblProductList.AutoSize = true;
            this.LblProductList.Location = new System.Drawing.Point(9, 9);
            this.LblProductList.Name = "LblProductList";
            this.LblProductList.Size = new System.Drawing.Size(80, 13);
            this.LblProductList.TabIndex = 2;
            this.LblProductList.Text = "List of Products";
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(214, 29);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(122, 43);
            this.BtnAddProduct.TabIndex = 3;
            this.BtnAddProduct.Text = "Add Product";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.Location = new System.Drawing.Point(214, 78);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(122, 43);
            this.BtnUpdateProduct.TabIndex = 4;
            this.BtnUpdateProduct.Text = "Update Product";
            this.BtnUpdateProduct.UseVisualStyleBackColor = true;
            this.BtnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Location = new System.Drawing.Point(214, 127);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(122, 43);
            this.BtnDeleteProduct.TabIndex = 5;
            this.BtnDeleteProduct.Text = "Delete Product";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            -CreateLayoutOfForm
            this.ClientSize = new System.Drawing.Size(365, 207);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.LblProductList);
            this.Controls.Add(this.LbProducts);
            this.Name = "Form1";
            this.Text = "Rat Hut Product Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbProducts;
        private System.Windows.Forms.Label LblProductList;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnUpdateProduct;
        private System.Windows.Forms.Button BtnDeleteProduct;
    }
}

