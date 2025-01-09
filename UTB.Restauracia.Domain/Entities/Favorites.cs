
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    public class Favorites
    {
        [Required]
        public int Id { get; set; }

        [ForeignKey(nameof(Food))]
        public int FoodId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }


        public required CustomerUser? User { get; set; }
        public required Food? Food { get; set; }
    }
}
