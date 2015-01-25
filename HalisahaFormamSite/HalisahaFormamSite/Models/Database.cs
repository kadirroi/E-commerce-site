using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HalisahaFormamSite.Models
{
    public class Database :DbContext
    {
       
        
        public DbSet<Product> Products { get; set; }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User>Users { get; set; }
        public DbSet<City> Citys { get; set; }
      
        
        public DbSet<OrderDetail> OrderDetails { get; set; }



     


    }
}