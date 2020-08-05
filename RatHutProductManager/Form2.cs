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

            if ( !Validator.IsInt32(TxtProductPrice.Text))
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




        }
    }
}
