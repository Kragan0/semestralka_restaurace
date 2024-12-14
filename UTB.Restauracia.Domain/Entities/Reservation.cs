using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Reservation))]
    public class Reservation
    {

        public int Id {  get; set; }
        public DateTime Time { get; set; }
        public required byte NumberOfGuests { get; set; }
        public string SpecialRequest { get; set; } = "";
        
        // Foreign keys
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        [ForeignKey(nameof(RestaurantTable))]
        public int TableId { get; set; }

        public required User User { get; set; }
        public required RestaurantTable RestaurantTable { get; set; }

    }
}
