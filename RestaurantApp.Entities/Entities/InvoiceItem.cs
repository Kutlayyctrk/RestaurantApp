using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceID { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }

    }
}
