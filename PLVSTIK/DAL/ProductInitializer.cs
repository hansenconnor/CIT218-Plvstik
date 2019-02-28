using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PLVSTIK.Models;

namespace PLVSTIK.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {

            // Initialize Product Category sample data
            var productCategories = new List<ProductCategory>
            {
                new ProductCategory { Name="Bags" },
                new ProductCategory { Name="Shirts" },
                new ProductCategory { Name="Pants" },
                new ProductCategory { Name="Glasses" },
            };
            // Add entries to the corresponding table
            productCategories.ForEach(pc => context.ProductCategories.Add(pc));
            context.SaveChanges(); // Save changes to Product Categories table


            // Initialize Product sample data
            var products = new List<Product>
            {
                new Product
                {
                    Title = "Black Bag",
                    Description = "Awesome Black bag",
                    ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1465493404/431665_EV4CX_1060_001_073_0000_Light-Sylvie-medium-crocodile-top-handle-bag.jpg",
                    Price = 50.00,
                    Categories = new List<ProductCategory>
                    {
                        productCategories.Find(Category => Category.Name == "Bags"),
                        productCategories.Find(Category => Category.Name == "Shirts"),
                    }
                },
                new Product{ Title="Red Bag", Description="PLVSTIK X GUCCI BAG - RED", Price=50.00, ImageUrl="https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1473267618/431665_EV4CG_6473_001_073_0000_Light-Sylvie-medium-crocodile-top-handle-bag.jpg", Featured = true  },
                new Product{ Title="White Shirt", Description="PLVSTIK X GUCCI SHIRT - WHITE", ImageUrl="https://images.bergdorfgoodman.com/ca/4/product_assets/M/2/2/2/L/BGM222L_mu.jpg", Price=50.00 },
                new Product{ Title="Black Shirt", Description="PLVSTIK X GUCCI SHIRT - Black", ImageUrl="https://eyeconicwear.com/wp-content/uploads/2017/03/EyeConicWear-gucci-gg-classic-t-shirt-black.jpg", Price=50.00 },
                new Product{ Title="Sweat Shirt", Description="PLVSTIK X GUCCI HOODIE - WHITE", ImageUrl="https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1519803905/454585_X5J57_9541_001_100_0000_Light-Oversize-sweatshirt-with-Gucci-logo.jpg", Price=50.00 },
                new Product{ Title="Sunglasses", Description="PLVSTIK X GUCCI SUNGLASSES", ImageUrl="https://www.framesdirect.com/product_elarge_images/gucci-sunglasses-gg0212s-001.jpg", Price=50.00 }
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
        }
    }
}