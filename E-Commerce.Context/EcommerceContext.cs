using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace E_Commerce.Context
{
    public class EcommerceContext:DbContext
    { 
        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Category>    Categories { set; get; } 
        public virtual DbSet<Admin> Admins { set; get; } 
        public virtual DbSet<Cartitem> CartItems { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TBIFCVN\\SQLEXPRESS;Initial Catalog=EcommerceOnion;Integrated Security=True;Encrypt=False;");
        }
    }
}
