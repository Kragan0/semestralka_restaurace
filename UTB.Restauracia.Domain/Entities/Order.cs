using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Restauracia.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        // Dine-in alebo Delivery
        public string OrderType { get; set; }
        // Status like Pending, Completed 
        public string Status { get; set; }

        // In case we will do delivery
        public string? DeliveryAddress {get; set;} 
        
        public int UsertId { get; set; }
        public User User { get; set; }
        public IList<OrderItems> OrderItems { get; set; } 
    
    }
}
