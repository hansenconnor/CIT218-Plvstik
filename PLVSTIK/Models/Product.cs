using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLVSTIK.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        public ProductCategory[] Categories { get; set; } // Array to hold associated product categories
    }
}