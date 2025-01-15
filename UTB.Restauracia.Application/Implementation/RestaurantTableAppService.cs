using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database;

namespace UTB.Restauracia.Application.Implementation
{
    public class RestaurantTableAppService : IRestaurantTableAppService
    {
        RestauraciaDbContext _restauraciaDbContext;
        public RestaurantTableAppService(RestauraciaDbContext restauraciaDbContext)
        {
            _restauraciaDbContext = restauraciaDbContext;
        }
        public IList<RestaurantTable> Select()
        {
            return _restauraciaDbContext.RestaurantTables.ToList();
        }

        public void Create(RestaurantTable restaurantTable)
        {

            _restauraciaDbContext.RestaurantTables.Add(restaurantTable);
            _restauraciaDbContext.SaveChanges();
        }
        public bool Delete(int id)
        {
            bool deleted = false;

            RestaurantTable? restaurantTable = _restauraciaDbContext.RestaurantTables.FirstOrDefault(rt => rt.Id == id);
            if (restaurantTable != null)
            {
                _restauraciaDbContext.RestaurantTables.Remove(restaurantTable);
                _restauraciaDbContext.SaveChanges();
                deleted = true;
            }
            return deleted;
        }
    }
}
