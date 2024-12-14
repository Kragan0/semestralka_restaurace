using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(OrderItems))]
    public class OrderItems
    {
        public int Id { get; set; }
        // Foreign keys 
        
        [ForeignKey(nameof(Order))]
        public int OrderID { get; set; }
        [ForeignKey(nameof(Food))]
        public int MenuItemID   { get; set; }

        public required Order order { get; set; }
        public required Food food { get; set; }
    }
}
