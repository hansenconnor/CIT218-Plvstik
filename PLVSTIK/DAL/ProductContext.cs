using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using PLVSTIK.Models;

namespace PLVSTIK.DAL
{
    public class ProductContext : DbContext
    {
        // Assign a name to the connection string
        public ProductContext() : base("ProductContext")
        {

        }

        // Define entities
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

        // Create tables and pluralize entity names
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}