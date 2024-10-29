﻿using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database.Seeding;


namespace UTB.Restauracia.Infrastructure.Database
{
    public class RestauraciaDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }
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

            MenuItemInit menuItemInit = new MenuItemInit();
            modelBuilder.Entity<MenuItem>().HasData(menuItemInit.GetMenuItems3());
            RestaurantTableInit restaurantTableInit = new RestaurantTableInit();
            modelBuilder.Entity<RestaurantTable>().HasData(restaurantTableInit.GetRestaurantTables3());

        }
    }
}