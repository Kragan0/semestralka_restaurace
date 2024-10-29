using System.ComponentModel.DataAnnotations.Schema;
    
namespace UTB.Restauracia.Domain.Entities
{

    [Table(nameof(User))]
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string FullName { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        // Mozno nejaka rola pre zakaznika v restauraci a mimo restauracie
        // public string Role {get; set;} 
        
        public IList<Reservation>? Reservations { get; set; } = null;
        public IList<Order>? Orders { get; set; } = null;
    }

}
