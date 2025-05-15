using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // Ürün ID
        public DateTime TranscationDate { get; set; } // İşlem tarihi
        public int Quantity { get; set; } // Miktar
        public string TransactionType { get; set; } // İşlem türü (Giriş/Çıkış)

        public Product Product { get; set; } // Ürün bilgisi
    }
}
