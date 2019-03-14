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

        [HttpPost]
        public ActionResult Index(string name) // Pre-Order success view/message
        {
            ViewBag.Message = "Thank you for your pre-order, " + name + "!";
            return View("PreOrderSuccess");
        }

        [HttpGet]
        public ActionResult Index( string gender, string category, string price )
        {
            ViewBag.MyQSVal = Request.QueryString; // Query String

            ViewBag.Genders = new string[2] { "male", "female" }; // List of gender categories

            //var asdf = db.Products.Where(p => p.Categories


            ViewBag.Gender = String.IsNullOrEmpty(gender) ? null : gender;
            ViewBag.Category = String.IsNullOrEmpty(category) ? "shirts" : category;
            ViewBag.Price = String.IsNullOrEmpty(price) ? "descending" : price;

            // Default => Display all products if query string is empty
            if ((Request.QueryString == null) || String.IsNullOrEmpty(Request.QueryString.ToString()))
            {
                return View("Index", db.Products.ToList());
            }
            else // Otherwise, query and display products according to the user query
            {
                var products = db.Products
                .Where(b => b.Categories
                .Any(s => s.Name == category.ToString()));

                return View("Index", products.ToList());
            }
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
            foreach (Product product in db.Products)
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
