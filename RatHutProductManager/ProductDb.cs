using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
        /// <summary>
        /// Updates or modifies a product already in the database
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Product Update(Product p)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets a list of all products in the database
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Deletes product according to ProductId
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
