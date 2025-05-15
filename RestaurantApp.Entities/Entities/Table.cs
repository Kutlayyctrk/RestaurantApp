using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Entities.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool IsOccupied { get; set; }
        
        public Collection<Reservation> Reservations { get; set; }
        public Collection<Order> Orders { get; set; }
    }
}
