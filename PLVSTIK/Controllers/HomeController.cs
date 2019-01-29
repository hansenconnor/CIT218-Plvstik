using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PLVSTIK.Models;

namespace PLVSTIK.Controllers
{
    public class HomeController : Controller
    {

        List<Product> prodList = new List<Product>
            {
                new Product
                {
                    Id = 0,
                    Title = "Hand Bag",
                    Description = "Classy handbag to take with you anywhere.",
                    Price = 50.00,
                },
            };


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public ActionResult About()
        {
            return View();
        }

        //[HttpPost]
        //[Route("Contact")]
        //public ActionResult Contact(string name)
        //{
        //    ViewBag.Message = "Thank you for contacting us, " + name + "!";
        //    return View("ContactFormSuccess");
        //}

        [Route("Contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("ContactFormSuccess")]
        public ActionResult ContactFormSuccess()
        {
            return View();
        }

        //public ActionResult Shop(int? productId)
        //{
        //Product product = new Product();

        //foreach (Product product in products.ProdList)
        //{
        //    if (product.Id == productId)
        //    {
        //        ViewBag.productId.ToString();
        //    }
        //}
        //return View(myProduct);
        //}

    }
}