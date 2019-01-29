using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PLVSTIK.Models; // Add a using statement to include the model's namespace.

namespace PLVSTIK.Controllers
{
    public class ShopController : Controller
    {
        // Create a list of products
        List<Product> products = new List<Product> // Create a object using the model class, add values to the properties and pass the object to a view
    {
            new Product
            {
                Id = 1,
                Title = "PLVSTIK Purse",
                Description = "Limited edition PLVSTIK purse. Availabile in pink or blue.",
                Price = 50.00,
                ImageUrl = "https://images.unsplash.com/photo-1524672353063-4f66ee1f385e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1349&q=80",
            },
            new Product
            {
                Id = 2,
                Title = "PLVSTIK Shirt",
                Description = "Custom PLVSTIK shirt featuring a skeleton hand graphic.",
                Price = 20.00,
                ImageUrl = "https://images.unsplash.com/photo-1503342217505-b0a15ec3261c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1350&q=80",
            },
            new Product
            {
                Id = 3,
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

        public ActionResult Index() // Display all products
        {
            return View (products); // Pass the products to the Index view
        }

        public ActionResult PreOrderSuccess()
        {
            return View(); // Pre-Order success view/message
        }

        public ActionResult ViewProduct(int productId) // Product single view
        {
            foreach (Product product in products)
            {
                if (product.Id == productId)
                {
                    return View(product);
                }
            }
            return View();
        }
    }
}
