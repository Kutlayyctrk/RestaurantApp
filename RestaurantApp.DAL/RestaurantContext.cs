using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestaurantApp.Entities;

namespace RestaurantApp.DAL
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("name=RestaurantDbConnectionString")
        {

        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Category> Categories { get; set; }




    }
}
