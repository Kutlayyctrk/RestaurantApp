using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class Shift
    {
        public int Id { get; set; } // Shift ID

        public int StaffId { get; set; } // Çalışan ID

        public DateTime StartTime { get; set; } // Shift başlangıç zamanı
        public DateTime EndTime { get; set; } // Shift bitiş zamanı
        
        public Staff Staff { get; set; } // Çalışan bilgisi
    }
}
