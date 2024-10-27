using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Restauracia.Domain.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public int SeatCapacity { get; set; }
        public bool IsAvailable {  get; set; }

        // Foreign key 
        public IList<Reservation> Reservations { get; set; }
        

    }
}
