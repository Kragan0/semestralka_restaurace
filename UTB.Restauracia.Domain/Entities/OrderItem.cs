using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(OrderItem))]
    public class OrderItem
    {
        [Required]
        public int Id { get; set; }
        // Foreign keys 
        
        [ForeignKey(nameof(Order))]
        public int OrderID { get; set; }
        [ForeignKey(nameof(Food))]
        public int FoodID { get; set; }

        [Required]
        public int Amount { get; set; }
        [Required]
        public double Price { get; set; }
        public Order? Order { get; set; }
        public Food? Food { get; set; }
    }   
}
