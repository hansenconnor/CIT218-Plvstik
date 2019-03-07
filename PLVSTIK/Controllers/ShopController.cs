using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PLVSTIK.DAL;
using PLVSTIK.Models; // Add a using statement to include the model's namespace.

namespace PLVSTIK.Controllers
{
    public class ShopController : Controller
    {
        private ProductContext db = new ProductContext(); // Create db instance
        // Create a list of products
        List<Product> products = new List<Product> // Create a object using the model class, add values to the properties and pass the object to a view
    {
            new Product
            {
                ID = 1,
                Title = "PLVSTIK Purse",
                Description = "Limited edition PLVSTIK purse. Availabile in pink or blue.",
                Price = 50.00,
                ImageUrl = "https://images.unsplash.com/photo-1524672353063-4f66ee1f385e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1349&q=80",
            },
            new Product
            {
                ID = 2,
                Title = "PLVSTIK Shirt",
                Description = "Custom PLVSTIK shirt featuring a skeleton hand graphic.",
                Price = 20.00,
                ImageUrl = "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80",
            },
            new Product
            {
                ID = 3,
                Title = "PLVSTIK Sunglasses",
                Description = "PLVSTIK x RayBan sunglasses with a classic green tint.",
                Price = 150.00,
                ImageUrl = "https://images.unsplash.com/photo-1511499767150-a48a237f0083?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1000&q=80",
            },
        };

        [HttpPost]
        public ActionResult Index(string name) // Pre-Order success view/message
        {
            ViewBag.Message = "Thank you for your pre-order, " + name + "!";
            return View("PreOrderSuccess");
        }

        [HttpGet]
        public ActionResult Index( string order, string type, string timeframe )
        {
            ViewBag.Order = String.IsNullOrEmpty(order) ? "most_views" : order;
            ViewBag.Type = String.IsNullOrEmpty(type) ? "All Products" : "";
            ViewBag.Timeframe = String.IsNullOrEmpty(timeframe) ? "All Time" : "";

            // TODO: filter products

            // TODO: Switch here to set friendly name for order, type, and timeframe ex. most_views => Most Views

            return View("Index", db.Products.ToList());
        }

        public ActionResult Index(bool featured = false) // Display all products
        {
            //ViewBag.NameSortParam = String.IsNullOrEmpty(order) ? "sort" : "";
            //ViewBag.DateSortParam = order == "Date" ? "date_desc" : "Date";

            //var shopItems = from p in products
            //                where p.Categories.Contains(type as ProductCategory)

            // TODO: Add additional filters: Timeframe, popularity, etc.
            if (featured)
            {
                return View(db.Products.Where(p => p.Featured).ToList());
            }
            return View(db.Products.ToList());
        }

        public ActionResult PreOrderSuccess()
        {
            return View(); // Pre-Order success view/message
        }

        public ActionResult ViewProduct(int productId) // Product single view
        {
            foreach (Product product in products)
            {
                if (product.ID == productId)
                {
                    return View(product);
                }
            }
            return View();
        }
    }
}
