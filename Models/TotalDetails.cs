using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLab.Models
{
    /// <summary>
    ///  Model representing both product and inventory data
    /// </summary>
    public class TotalDetails
    {
        public List<Product> Products { get; set; }
        public List<Inventory> Inventory { get; set; }
    }
}