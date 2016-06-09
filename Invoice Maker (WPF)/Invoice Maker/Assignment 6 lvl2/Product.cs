using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_lvl2
{
    public class Product
    {
        /// <summary>
        /// Default constructor Product.
        /// </summary>
        public Product() { }

        /// <summary>
        /// Gets and sets the current number of items. 
        /// </summary>
        public int Items { get; set; }

        /// <summary>
        /// Gets and sets the description of an item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets and sets the quantity of an item.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Gets and sets the unit price of an item.
        /// </summary>
        public string UnitPrice { get; set; }

        /// <summary>
        /// Gets and sets the tax of an item.
        /// </summary>
        public string Tax { get; set; }

        /// <summary>
        /// Gets and sets the total tax for all the items.
        /// </summary>
        public double TotalTax { get; set; }

        /// <summary>
        /// Gets and sets the total amount to pay.
        /// </summary>
        public double Total { get; set; }
    }
}
