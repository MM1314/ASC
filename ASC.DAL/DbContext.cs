using System;
using System.Data.Entity;
using ASC.Models;

namespace ASC.DAL
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext()
            : base("MyDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
    }
}
