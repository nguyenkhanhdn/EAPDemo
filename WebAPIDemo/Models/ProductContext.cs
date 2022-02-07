using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(): base("name=DefaultConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
    }

}