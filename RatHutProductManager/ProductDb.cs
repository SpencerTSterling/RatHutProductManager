using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RatHutProductManager
{
    static class ProductDb
    {
        /// <summary>
        /// Adds product to the database
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Product Add(Product p)
        {
            using ( ProductContext context = new ProductContext())
            {
                context.Products.Add(p);
                context.SaveChanges();
                return p;
            }
        }
        /// <summary>
        /// Deletes product from the database
        /// </summary>
        /// <param name="p"></param>
        public static void Delete(Product p)
        {
            using (ProductContext context = new ProductContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Entry(p).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Updates or modifies a product already in the database
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Product Update(Product p)
        {
            using( ProductContext context = new ProductContext())
            {
                context.Entry(p).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return p;
            }
        }
        /// <summary>
        /// Gets a list of all products in the database
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetAllProducts()
        {
            using (ProductContext context = new ProductContext())
            {
                List<Product> allProduct =
                    (from prod in context.Products
                     select prod).ToList();

                return allProduct;
            };
        }
        /// <summary>
        /// Deletes product according to ProductId
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public static List<Product> SortAlphabetically()
        {
            using(ProductContext context = new ProductContext())
            {
                List<Product> products =
                    (from prod in context.Products
                     orderby prod.Title ascending
                     select prod).ToList();

                return products;
            };
        }
    }
}
