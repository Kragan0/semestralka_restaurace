using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
namespace UTB.Restauracia.Domain.Entities
{
    
    [Table(nameof(CustomerUser))]
    public class CustomerUser
    {
        [Required]
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required string FullName { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        
        public IList<Reservation>? Reservations { get; set; } = null;
        public IList<Order>? Orders { get; set; } = null;
        public IList<Favorite> Favorites { get; set; }
    }

}
