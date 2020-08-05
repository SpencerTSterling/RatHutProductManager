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
            throw new NotImplementedException();
        }
    }
}
