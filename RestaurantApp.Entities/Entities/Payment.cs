using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class Payment
    {
        public int Id { get; set; } // Ödeme ID
        public int OrderId { get; set; } // Sipariş ID
        public decimal Amount { get; set; } // Ödeme miktarı
        public DateTime PaymentDate { get; set; } // Ödeme tarihi
        public string PaymentMethod { get; set; } // Ödeme yöntemi (Nakit/Kredi Kartı vb.)
        
        public Order Order { get; set; } // Sipariş bilgisi
    }
}
