using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLVSTIK.Models
{
    public enum Category
    {
        Bag, Shirt, Sweatshirt, Backpack, Glasses
    }

    public class ProductCategory
    {
        public int ID { get; set; }
        public Category Category { get; set; }

    }
}