using EntityFrameWorkSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkSample.Data
{
    /// <summary>
    /// To Access and connection with required database 
    /// A DBContext class is neened and drived from DbContext class.
    /// </summary>
    public class ShopContext : DbContext    
    {
        //Each DbSet Maps to a table in database.
        public DbSet<Customer> Customers { get; set; } = null!;
        
        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;


        //To configure the Databse Connection or Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            //UseSqlServer is an extension method in Microsoft.EntityFrameworkCore.SqlServer
            //Here we are hardcoding Connecting string for Demo purpose.
            //Replace with your connection string and also do not hardcode.
            //Connection string is use o connect
            string ConnectionString = @"Data Source=VU-IT-ISHFAQ\SQLEXPRESS;Initial Catalog=Shop;User ID=sa;Password=devdb456;Persist Security Info=False;Encrypt=False;";
            optionsBuilder.UseSqlServer(ConnectionString); 
        }
    }
}
