using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Restauracia.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        // Mozno nejaka rola pre zakaznika v restauraci a mimo restauracie
        // public string Role {get; set;} 
        // Foreign keys
        public IList<Reservation>? Reservations { get; set; }
        public IList<Order>? Orders { get; set; }
    }

}
