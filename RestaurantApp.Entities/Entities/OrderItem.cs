﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProdcutId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public decimal Total=>Product!=null? Product.Price * Quantity : 0;
    }
}
