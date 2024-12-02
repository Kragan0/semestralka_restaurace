using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Food))]
    public class Food
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = "";
        public string Icon { get; set; } = "";
        public required double Price { get; set; }

        [ForeignKey(nameof(Menu))]
        public required int MenuId { get; set; }

       
        public Menu Menu { get; set; }
        public IList<OrderItems>? OrderItems { get; set; } = null;
        public Favorites Favorites { get; set; } = null;


    
        
    }
}
