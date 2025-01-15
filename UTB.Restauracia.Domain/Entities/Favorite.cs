
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTB.Restauracia.Domain.Entities.Interfaces;

namespace UTB.Restauracia.Domain.Entities
{
    public class Favorite
    {
        [Required]
        public int Id { get; set; }

        [ForeignKey(nameof(Food))]
        public int FoodId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public IUser<int> User { get; set; }
        
        public  Food? Food { get; set; }

    }
}
