using UTB.Restauracia.Domain.Entities;
namespace UTB.Restauracia.Application.Abstraction
{
    public interface IReservationAppService
    {
        public IList<Reservation> Select();
        public IList<Reservation> SelectForUser(int userId);
        public IList<RestaurantTable> GetTables(); 
        public void Create(Reservation reservation);
        public bool Delete(int id);
    }
}
