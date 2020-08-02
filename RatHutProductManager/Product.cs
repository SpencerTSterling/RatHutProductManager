using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatHutProductManager
{
    /// <summary>
    /// Represents an individual menu item at RutHut
    /// </summary>
    class Product
    {
        /// <summary>
        /// Unique Id number for each product
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Title for the product for customers
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The price of the product in US currency
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Simple description of the product
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Categories for products include Burgers, Chicken, Breakfast, Sides, and Dessert
        /// </summary>
        public string Category { get; set; }
    }
}
