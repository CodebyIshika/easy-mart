using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLab.Models
{
    public class TotalDetails
    {
        public List<Product> Products { get; set; }
        public List<Inventory> Inventory { get; set; }
    }
}