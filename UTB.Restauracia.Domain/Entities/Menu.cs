using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Menu))]
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Food> Foods { get; set; } = null;
    }
}
