using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Order))]
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        // Dine-in alebo Delivery
        public string OrderType { get; set; }
        // Status ako Pending, Completed 
        public string Status { get; set; }

        // Ak budeme robit donasku
        public string? DeliveryAddress {get; set;}

        [ForeignKey(nameof(User))]
        public int UsertId { get; set; }
        
        public User User { get; set; }
        public IList<OrderItems> OrderItems { get; set; } 
    
    }
}
