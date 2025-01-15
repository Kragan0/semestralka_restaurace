using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database;

namespace UTB.Restauracia.Application.Implementation
{
    public class ReservationAppService : IReservationAppService
    {
        RestauraciaDbContext _restauraciaDbContext;

        public ReservationAppService(RestauraciaDbContext restauraciaDbContext)
        {
            _restauraciaDbContext = restauraciaDbContext;
        }
        public IList<Reservation> Select()
        {
            return _restauraciaDbContext.Reservations.Include(r => r.User).ToList();
        }
        public IList<RestaurantTable> GetTables()
        {
            return _restauraciaDbContext.RestaurantTables.ToList();
        }

        public IList<Reservation> SelectForUser(int userId)
        {
            return _restauraciaDbContext.Reservations.Where(re => re.UserId == userId)
                                         .Include(r => r.User)
                                         .Include(r => r.RestaurantTable)
                                         .ToList();
        }
        public void Create(Reservation reservation)
        {
            
            _restauraciaDbContext.Reservations.Add(reservation);
            _restauraciaDbContext.SaveChanges();
        }
        public bool Delete(int id)
        {
            bool deleted = false;

            Reservation? reservation = _restauraciaDbContext.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservation != null)
            {
                _restauraciaDbContext.Reservations.Remove(reservation);
                _restauraciaDbContext.SaveChanges();
                deleted = true;
            }
            return deleted;
        }
    }
}
