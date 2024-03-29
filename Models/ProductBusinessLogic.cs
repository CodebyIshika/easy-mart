﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLab.Models
{
    public class ProductBusinessLogic
    {
        public static List<Product> ProductList = new List<Product>();

        // Add a new product to the list
        public bool AddProduct(Product item)
        {
            ProductList.Add(item);
            return true;
        }

        // Retrieve the list of products
        public List<Product> GetProductList()
        {
            return ProductList;
        }

        // Delete a product by its ID
        public bool DeleteProduct(int productId)
        {
            var product = ProductList.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                ProductList.Remove(product);
                return true;
            }

            return false;
        }

        
    }
}