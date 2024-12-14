using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Order))]
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        // Dine-in alebo Delivery
        public required string OrderType { get; set; }
        // Status ako Pending, Completed 
        public required string Status { get; set; }
        // Ak budeme robit donasku
        public string? DeliveryAddress {get; set;}

        [ForeignKey(nameof(User))]
        public int UsertId { get; set; }
        
        public required User User { get; set; }
        public required IList<OrderItems> OrderItems { get; set; } 
    
    }
}
