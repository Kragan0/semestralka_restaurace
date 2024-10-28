using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class RestaurantTableInit
    {
        public IList<RestaurantTable> GetRestaurantTables3()
        {
            IList<RestaurantTable> restaurantTables = new List<RestaurantTable>();

            restaurantTables.Add(new RestaurantTable()
            {
                Id = 1,
                TableNumber = 1,
                SeatCapacity = 4,
                IsAvailable = true,
                Reservations = null

            });

            restaurantTables.Add(new RestaurantTable()
            {
                Id = 2,
                TableNumber = 2,
                SeatCapacity = 2,
                IsAvailable = true,
                Reservations = null
            });

            restaurantTables.Add(new RestaurantTable()
            {
                Id = 3,
                TableNumber = 3,
                SeatCapacity = 4,
                IsAvailable = true,
                Reservations = null
            });

            return restaurantTables;
        }
    }
}
