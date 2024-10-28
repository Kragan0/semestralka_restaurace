using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(MenuItem))]
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public double Price { get; set; }

        // Foreign Keys
        public IList<OrderItems>? OrderItems { get; set; } = null;
    }
}
