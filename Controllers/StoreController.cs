using MvcLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLab.Controllers
{
    public class StoreController : Controller
    {
        public static int counter = 1;
        public static int inventory = 101;
        ProductBusinessLogic pblObj = new ProductBusinessLogic();
        InventoryBusinessLogic iblObj = new InventoryBusinessLogic();
        // GET: Store
        public ActionResult Index()
        {
            var products = pblObj.GetProductList();
            return View(products);
        }

        public ActionResult Products()
        {
            return View("AddProduct");
        }

        public ActionResult AddProduct(string Name, string Description, decimal? ProductPrice, int? StockQuantity)
        {
            Product productObj = new Product
            {
                ProductID = counter++,
                ProductName = Name,
                Description = Description,
                Price = ProductPrice
            };

            Inventory inventoryObj = new Inventory(productObj)
            {
                InventoryID = inventory++,
                StockQuantity = StockQuantity
            };

            
            // Add the product 
            pblObj.AddProduct(productObj);

            // Add the product to the inventory
            iblObj.AddInventory(inventoryObj);

            return RedirectToAction("Index");
        }

        public ActionResult DisplayInventory()
        {
            // Retrieve both product and inventory data
            var products = pblObj.GetProductList();
            var inventory = MvcLab.Models.InventoryBusinessLogic.InventoryList;

            // Create a ViewModel to hold both product and inventory data
            var viewModel = new TotalDetails
            {
                Products = products,
                Inventory = inventory
            };

            return View("DisplayInventory", viewModel);
        }

        public ActionResult DeleteProduct(int productId)
        {
            // Delete product from the product list
            pblObj.DeleteProduct(productId);

            // Redirect to DisplayInventory after deleting a product
            return RedirectToAction("DisplayInventory");
        }

    }
}