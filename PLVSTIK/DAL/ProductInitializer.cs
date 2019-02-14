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
                new Product{ID=1,Title="Black Bag", Description="Awesome Black bag", ImageUrl="#", Price=50.00, Category },
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
                new User{ ID=1, Email="asdf@gmail.com", FirstName="Alex", LastName="df" },
                new User{ ID=1, Email="jf333@gmail.com", FirstName="Jessica", LastName="df" },
                new User{ ID=1, Email="asdf787@gmail.com", FirstName="David", LastName="df" },
                new User{ ID=1, Email="90hsjkdfh@gmail.com", FirstName="Deb", LastName="df" },
                new User{ ID=1, Email="asdf73j@gmail.com", FirstName="Jim", LastName="Halpert" },
                new User{ ID=1, Email="alsdf83h@gmail.com", FirstName="Pam", LastName="Beesley" },
            };
            // Add entries to the corresponding table
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges(); // Save changes to User table


            // Initialize Product Category sample data
            var productCategories = new List<ProductCategory>
            {
                new ProductCategory { ID=1, Name="Backpacks" },
                new ProductCategory { ID=2, Name="Shirts" },
                new ProductCategory { ID=3, Name="Glasses" },
                new ProductCategory { ID=4, Name="Bags" },
                new ProductCategory { ID=5, Name="Hoodies" }
            };
            // Add entries to the corresponding table
            productCategories.ForEach(pc => context.ProductCategories.Add(pc));
            context.SaveChanges(); // Save changes to Product Categories table
        }
    }
}