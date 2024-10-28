using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database.Seeding;


namespace UTB.Restauracia.Infrastructure.Database
{
    public class RestauraciaDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }


        public RestauraciaDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
        }
    }
}
