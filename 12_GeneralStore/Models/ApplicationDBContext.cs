using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _12_GeneralStore.Models
{
    public class ApplicationDBContext : DbContext
    {
        // Tell our ApplicationDBContext how to connect to our local SQL database
        public ApplicationDBContext() : base("DefaultConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}