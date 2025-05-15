using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestaurantApp.Entities;
using RestaurantApp.Entities.Entities;

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
        public DbSet<Order> Orderdes { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<StockTransaction> StockTransactions { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Payment> Payments { get; set; }

        
    }
}
