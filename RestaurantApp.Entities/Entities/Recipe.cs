using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MeterialProductId { get; set; } // Malzeme ürün id
        public decimal Quantity { get; set; } // Malzeme miktarı

        public Product Product { get; set; } // Ürün
        
    }
}
