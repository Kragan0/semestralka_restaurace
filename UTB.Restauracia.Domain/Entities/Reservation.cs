using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTB.Restauracia.Domain.Entities.Interfaces;
using UTB.Restauracia.Domain.Validations;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Reservation))]
    public class Reservation
    {
        [Required]
        public int Id {  get; set; }
        [ReservationTableValidation]
        public DateTime Time { get; set; }
        public required byte NumberOfGuests { get; set; }
        public string SpecialRequest { get; set; } = "";

        // Foreign keys

        [ForeignKey(nameof(RestaurantTable))]
        public int TableId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public IUser<int>? User { get; set; }
        public RestaurantTable? RestaurantTable { get; set; }
        

    }
}
