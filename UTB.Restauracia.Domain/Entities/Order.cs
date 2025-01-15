using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTB.Restauracia.Domain.Entities.Interfaces;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Order))]
    public class Order
    {
        [Required]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime OrderDate { get; set; }
        // Dine-in alebo Delivery
        public string? OrderType { get; set; } = "";
        // Status ako Pending, Completed 
        public string? DeliveryAddress { get; set; } = "";

        [Required]
        public string OrderNumber { get; set; }
        [Required]
        public double TotalPrice { get; set; }

        [ForeignKey(nameof(User))]
        public int UsertId { get; set; }       
        public IUser<int> User { get; set; }
        public IList<OrderItem> OrderItems { get; set; } 
    
    }
}
