using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTB.Restauracia.Domain.Validations;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Food))]
    public class Food
    {
        [Required]
        public int Id { get; set; }
        [FirstLetterCapitalizedCZAttribute]
        public required string Name { get; set; }
        [FirstLetterCapitalizedCZAttribute]
        public string? Description { get; set; } = "";
        public string? Icon { get; set; } = "";
        public required double Price { get; set; }

        [ForeignKey(nameof(Menu))]
        public required int MenuId { get; set; }
        public Menu? Menu { get; set; }
        public IList<OrderItems>? OrderItems { get; set; } = null;
        public Favorites? Favorites { get; set; } = null;


    
        
    }
}
