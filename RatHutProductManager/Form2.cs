using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatHutProductManager
{
    public partial class AddAndUpdateForm : Form
    {
        public AddAndUpdateForm()
        {
            InitializeComponent();
        }
        Product updProduct;
        public AddAndUpdateForm(Product product)
        {
            InitializeComponent();
            TxtProductTitle.Text = product.Title;
            TxtProductPrice.Text = product.Price.ToString();
            TxtProductDesc.Text = product.Description;
            BtnAddToDB.Text = "Update";
            switch (product.Category.ToLower())
            {
                case "burgers":
                    RbCatBurgers.Checked = true;
                    break;
                case "chicken/sandwiches":
                    RbCatChickenSand.Checked = true;
                    break;
                case "breakfast":
                    RbCatBreakfast.Checked = true;
                    break;
                case "sides":
                    RbCatSides.Checked = true;
                    break;
                case "dessert":
                    RbCatDessert.Checked = true;
                    break;
                case "misc":
                    RbCatMisc.Checked = true;
                    break;
                default:
                    break;
            }

            this.Text = "Update " + product.Title;
            updProduct = product;
        }

        private void AddAndUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddToDB_Click(object sender, EventArgs e)
        {
            // Make sure all inputs on forms are valid 
            #region Validation
            if (!Validator.IsPresent(TxtProductTitle) ||
                !Validator.IsPresent(TxtProductDesc))
            {
                MessageBox.Show("Please input a title and description for your product");
            }

            if ( !Validator.IsNumber(TxtProductPrice.Text))
            {
                MessageBox.Show("Please input a numerial value for the price");
            }

                // if none of the buttons are clicked, give error
            if ( !RbCatBreakfast.Checked &&
                 !RbCatBurgers.Checked &&
                 !RbCatChickenSand.Checked &&
                 !RbCatDessert.Checked &&
                 !RbCatSides.Checked &&
                 !RbCatMisc.Checked)
            {
                MessageBox.Show("Please choose a category for the product");
            }
            #endregion
            if (updProduct == null) {
                Product prod = new Product();

                prod.Title = TxtProductTitle.Text;
                prod.Price = Convert.ToDouble(TxtProductPrice.Text);
                prod.Description = TxtProductDesc.Text;
                prod.Category = GbProductCategory.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

                ProductDb.Add(prod);
            }
            else
            {
                updProduct.Title = TxtProductTitle.Text;
                updProduct.Price = Convert.ToDouble(TxtProductPrice.Text);
                updProduct.Description = TxtProductDesc.Text;
                updProduct.Category = GbProductCategory.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                ProductDb.Update(updProduct);
            }
            Close();
        }
    }
}
