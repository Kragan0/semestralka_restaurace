using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Restauracia.Domain.Entities
{
    [Table(nameof(Reservation))]
    public class Reservation
    {

        public int Id {  get; set; }
        public DateTime Time { get; set; }

        // Foreign keys
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        [ForeignKey(nameof(RestaurantTable))]
        public int TableId { get; set; }

        public User User { get; set; }
        public RestaurantTable RestaurantTable { get; set; }

    }
}
