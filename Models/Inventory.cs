using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLab.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int? StockQuantity { get; set; }

        public int ProductID { get; set; }

        public Product AccessProduct {  get; set; }

        public Inventory(Product accessProduct)
        {
            AccessProduct = accessProduct;
            ProductID = accessProduct.ProductID; // Set the Product id
        }



    }
}