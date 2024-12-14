using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database.Seeding;


namespace UTB.Restauracia.Infrastructure.Database
{
    public class RestauraciaDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Domain.Entities.Food> Foods { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        public RestauraciaDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Seeding.FoodInit menuItemInit = new Seeding.FoodInit();
            modelBuilder.Entity<Domain.Entities.Food>().HasData((IEnumerable<Domain.Entities.Food>)menuItemInit.GetMenuItems3());
            RestaurantTableInit restaurantTableInit = new RestaurantTableInit();
            modelBuilder.Entity<RestaurantTable>().HasData(restaurantTableInit.GetRestaurantTables3());

        }
    }
}