using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using UTB.Restauracia.Infrastructure.Identity;


namespace UTB.Restauracia.Infrastructure.Database
{
    public class RestauraciaDbContext : IdentityDbContext<User, Role, int>
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<CustomerUser> Users { get; set; }
        public DbSet<Favorites> Favorites { get; set; }

        public RestauraciaDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            MenuInit menuInit = new MenuInit();
            modelBuilder.Entity<Menu>().HasData(menuInit.GetMenus3());

            Seeding.FoodInit menuItemInit = new Seeding.FoodInit();
            modelBuilder.Entity<Domain.Entities.Food>().HasData((IEnumerable<Domain.Entities.Food>)menuItemInit.GetMenuItems3());

            RestaurantTableInit restaurantTableInit = new RestaurantTableInit();
            modelBuilder.Entity<RestaurantTable>().HasData(restaurantTableInit.GetRestaurantTables3());


            //Identity - User and Role initialization
            //roles must be added first
            RolesInit rolesInit = new RolesInit();
            modelBuilder.Entity<Role>().HasData(rolesInit.GetRolesAMC());
            //then, create users ..
            UserInit userInit = new UserInit();
            User admin = userInit.GetAdmin();
            User manager = userInit.GetManager();
            //.. and add them to the table
            modelBuilder.Entity<User>().HasData(admin, manager);
            //and finally, connect the users with the roles
            UserRolesInit userRolesInit = new UserRolesInit();
            List<IdentityUserRole<int>> adminUserRoles = userRolesInit.GetRolesForAdmin();
            List<IdentityUserRole<int>> managerUserRoles = userRolesInit.GetRolesForManager();
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(adminUserRoles);
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(managerUserRoles);

        }
    }
}