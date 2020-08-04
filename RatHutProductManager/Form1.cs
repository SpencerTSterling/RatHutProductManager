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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Testing out Add method
            //Product p = new Product()
            //{
            //    Title = "Burger",
            //    Price = 9.99
            //};
            //ProductDb.Add(p);

            // Testing out Update method
            //Product p = new Product()
            //{
            //    Title = "Hamburger",
            //    Price = 9.99
            //};
            //ProductDb.Add(p);

            //p.Price = 15.00;
            //ProductDb.Update(p);

         

        }

        private void LbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
