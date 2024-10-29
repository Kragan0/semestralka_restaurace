using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(MenuItem))]
    public class MenuItem
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = "";
        public string Icon { get; set; } = "";
        public required double Price { get; set; } 

       
        public IList<OrderItems>? OrderItems { get; set; } = null;
    }
}
