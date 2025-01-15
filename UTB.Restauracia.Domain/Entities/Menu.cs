using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTB.Restauracia.Domain.Validations;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Menu))]
    public class Menu
    {
        [Required]
        public int Id { get; set; }
        [FirstLetterCapitalizedCZAttribute]
        public string Name { get; set; }
        public IList<Food>? Foods { get; set; } = null;
    }
}
