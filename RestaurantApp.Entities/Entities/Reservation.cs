using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public string CustomerName { get; set; }

        public DateTime ReservationDate { get; set; }

        public int NumberOfPeople { get; set; } 

        public Table Table { get; set; }
    }
}
