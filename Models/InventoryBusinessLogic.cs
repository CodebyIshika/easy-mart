using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLab.Models
{
    public class InventoryBusinessLogic
    {
        public static List<Inventory> InventoryList = new List<Inventory>();

        public bool AddInventory(Inventory inventory)
        {
            InventoryList.Add(inventory);
            return true;
        }

        public List<Inventory> GetInventoryList()
        {
            return InventoryList.ToList();
        }

    }
}