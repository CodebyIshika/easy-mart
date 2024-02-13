using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLab.Models
{
    public class InventoryBusinessLogic
    {
        public static List<Inventory> InventoryList = new List<Inventory>();

        // Add an inventory item to the list
        public bool AddInventory(Inventory inventory)
        {
            InventoryList.Add(inventory);
            return true;
        }

        // Retrieve the list of inventory items
        public List<Inventory> GetInventoryList()
        {
            return InventoryList.ToList();
        }

    }
}