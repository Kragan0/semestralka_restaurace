using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(RestaurantTable))]
    public class RestaurantTable
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public byte SeatCapacity { get; set; }
        public bool IsAvailable {  get; set; }

        // Foreign key 
        public IList<Reservation>? Reservations { get; set; } = null;

    }
}
