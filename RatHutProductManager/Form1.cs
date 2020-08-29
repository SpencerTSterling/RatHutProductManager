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
            AddAndUpdateForm addForm = new AddAndUpdateForm();
            addForm.ShowDialog();
            RepopluateListBox();

        }

        private void RepopluateListBox()
        {
            LbProducts.Items.Clear();
            List<Product> allProducts = ProductDb.GetAllProducts();
            foreach (Product product in allProducts)
            {
                LbProducts.Items.Add(product);
            }
        }
        /// <summary>
        /// Takes in a list and puts it in the listbox
        /// </summary>
        /// <param name="allProducts"></param>
        private void RepopulateListBox(List<Product> allProducts)
        {
            LbProducts.Items.Clear();
            foreach(Product product in allProducts)
            {
                LbProducts.Items.Add(product);
            }
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (LbProducts.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a product to Update");
                return;
            }
            Product selPro = LbProducts.SelectedItem as Product;
            var updateFrm = new AddAndUpdateForm(selPro);
            updateFrm.ShowDialog();
            RepopluateListBox();
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            if ( LbProducts.SelectedIndex < 0)
            {
                MessageBox.Show("You must choose a product to delete");
                return;
            }

            Product prod = LbProducts.SelectedItem as Product;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {prod.Title}?", "Delete?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ProductDb.Delete(prod);
                    LbProducts.Items.Remove(prod);
                }
                catch
                {
                    MessageBox.Show("Try again");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get a list of all products from the database
            List<Product> allProducts = ProductDb.GetAllProducts();
            //Populates the listbox with the products
            foreach (Product product in allProducts)
            {
                LbProducts.Items.Add(product);
            }

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

        private void DdSortByCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the condition selected 
            int selectedIndex = DdSortByCondition.SelectedIndex;
            List<Product> products = new List<Product>();
            switch (selectedIndex)
            {
                // oldest to newest products (default)
                case 0:
                    // call method
                    products = ProductDb.SortByOldestProducts();
                    RepopulateListBox(products);
                    break;
                // newest to oldest products
                case 1:
                    // call method
                    products = ProductDb.SortByNewestProducts();
                    RepopulateListBox(products);
                    break;
                // lowest to highest price
                case 2:
                    // call method
                    products = ProductDb.SortLowestToHighestPrice();
                    RepopulateListBox(products);
                    break;
                // highest to lowest price
                case 3:
                    // call method
                    products = ProductDb.SortHighestToLowestPrice();
                    RepopulateListBox(products);
                    break;
                // alphabetical
                case 4:
                    // call method
                    products = ProductDb.SortAlphabetically();
                    RepopulateListBox(products);
                    break;

            }
            // Changes the category selected to All 
           // DdSortByCategory.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private List<Product> GetListBoxItems()
        {
            List<Product> products = new List<Product>();
            int size = LbProducts.Items.Count;
            for (int i = 0; i < size; i++)
            {
                LbProducts.SetSelected(i, true);
                products.Add(LbProducts.SelectedItem as Product);
            }
            LbProducts.SetSelected(size - 1, false);

            return products;
        }
    }
}
