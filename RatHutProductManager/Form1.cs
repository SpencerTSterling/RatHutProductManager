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
            DdSortByCondition_SelectedIndexChanged(sender, e);

        }

        private void RepopulateListBox()
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
            DdSortByCondition_SelectedIndexChanged(sender, e);
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
                    products = SortCategory(products);
                    RepopulateListBox(products);
                    break;
                // newest to oldest products
                case 1:
                    // call method
                    products = ProductDb.SortByNewestProducts();
                    products = SortCategory(products);
                    RepopulateListBox(products);
                    break;
                // lowest to highest price
                case 2:
                    // call method
                    products = ProductDb.SortLowestToHighestPrice();
                    products = SortCategory(products);
                    RepopulateListBox(products);
                    break;
                // highest to lowest price
                case 3:
                    // call method
                    products = ProductDb.SortHighestToLowestPrice();
                    products = SortCategory(products);
                    RepopulateListBox(products);
                    break;
                // alphabetical
                case 4:
                    // call method
                    products = ProductDb.SortAlphabetically();
                    products = SortCategory(products);
                    RepopulateListBox(products);
                    break;
                default:
                    products = ProductDb.SortByOldestProducts();
                    products = SortCategory(products);
                    RepopulateListBox(products);
                    break;

            }
            
        }

        private void DdSortByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DdSortByCondition_SelectedIndexChanged(sender, e);
            List<Product> products = GetListBoxItems();
            List<Product> pSorted = SortCategory(products);
            RepopulateListBox(pSorted);
        }

        /// <summary>
        /// Repopulates the listbox with items of the selected category
        /// </summary>
        private List<Product> SortCategory(List<Product> products)
        {
            //Runs if item selected is ALL
            if (DdSortByCategory.SelectedIndex != 0 && DdSortByCategory.SelectedItem != null)
            {
                List<Product> pSorted = new List<Product>();
                string category = DdSortByCategory.SelectedItem as string;
                int size = products.Count();
                for (int i = 0; i < size; i++)
                {
                    if (products[i].Category.Equals(category))
                    {
                        pSorted.Add(products[i]);
                    }
                }
                return pSorted;
            }
            return products;
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
            if (size < 0)
            {
                LbProducts.SetSelected(size - 1, false);
            }

            return products;
        }
    }
}
