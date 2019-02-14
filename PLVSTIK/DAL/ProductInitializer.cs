using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PLVSTIK.Models;

namespace PLVSTIK.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            // Initialize Product sample data
            var products = new List<Product>
            {
                new Product{ID=1,Title="Black Bag", Description="Awesome Black bag", ImageUrl="#", Price=50.00 },
                new Product{ID=1,Title="Red Bag", Description="Awesome Black bag", ImageUrl="#", Price=50.00 },
                new Product{ID=1,Title="White Shirt", Description="Awesome Black bag", ImageUrl="#", Price=50.00 },
                new Product{ID=1,Title="Black Shirt", Description="Awesome Black bag", ImageUrl="#", Price=50.00 },
                new Product{ID=1,Title="Sweat Shirt", Description="Awesome Black bag", ImageUrl="#", Price=50.00 },
                new Product{ID=1,Title="Sunglasses", Description="Awesome Black bag", ImageUrl="#", Price=50.00 }
            };
            // Add entries to the corresponding table
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges(); // Save changes to Product table


            // Initialize User sample data
            var users = new List<User>
            {
                new User{ ID=1, Email="asdf@gmail.com", FirstName="as", LastName="df" },
                new User{ ID=1, Email="asdf@gmail.com", FirstName="as", LastName="df" },
                new User{ ID=1, Email="asdf@gmail.com", FirstName="as", LastName="df" },
                new User{ ID=1, Email="asdf@gmail.com", FirstName="as", LastName="df" },
                new User{ ID=1, Email="asdf@gmail.com", FirstName="as", LastName="df" },
                new User{ ID=1, Email="asdf@gmail.com", FirstName="as", LastName="df" },
            };
            // Add entries to the corresponding table
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges(); // Save changes to User table


            // Initialize Product Category sample data
        }
    }
}