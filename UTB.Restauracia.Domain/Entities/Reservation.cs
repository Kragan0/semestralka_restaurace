using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Restauracia.Domain.Entities
{
    public class Reservation
    {

        private int Id {  get; set; }
        private DateTime time{ get; set; }
        
        // Foreign keys
        public int UserId { get; set; }
        public int TableId { get; set; }

        public User User { get; set; }
        public Table Table { get; set; }



    }
}
