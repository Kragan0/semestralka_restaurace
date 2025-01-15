using UTB.Restauracia.Domain.Entities;


namespace UTB.Restauracia.Application.ViewModels
{
    public class ReservationViewModel
    {
        public Reservation? reservation { get; set; }
        public IList<RestaurantTable>? restaurantTables { get; set; }
    }
}
