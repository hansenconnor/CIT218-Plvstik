using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLVSTIK.Models
{
    public class ProductCategory
    { 
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } // This is new
    }
}