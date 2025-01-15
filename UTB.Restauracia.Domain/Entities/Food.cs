using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTB.Restauracia.Domain.Validations;
using Microsoft.AspNetCore.Http;


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
        public string? ImageSrc { get; set; } = "";
        public required double Price { get; set; }

        [ForeignKey(nameof(Menu))]
        public required int MenuId { get; set; }
        public Menu? Menu { get; set; }
        public IList<OrderItem>? OrderItems { get; set; } = null;
        public Favorite? Favorites { get; set; } = null;

        [NotMapped]
        [FileContent("image")]
        public IFormFile? Image {  get; set; }
           
    }
}
