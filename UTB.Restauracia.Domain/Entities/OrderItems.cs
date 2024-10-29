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
        [ForeignKey(nameof(MenuItem))]
        public int MenuItemID   { get; set; }

        public required Order Order { get; set; }
        public required MenuItem MenuItem { get; set; }
    }
}
