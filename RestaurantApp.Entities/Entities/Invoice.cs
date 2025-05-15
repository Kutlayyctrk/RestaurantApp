using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
       
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public  string  SupplierName { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
