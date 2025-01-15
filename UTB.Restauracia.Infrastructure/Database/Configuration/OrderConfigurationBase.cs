using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Identity;


namespace UTB.Restauracia.Infrastructure.Database.Configuration
{
    internal class OrderConfigurationBase : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne<User>(e => e.User as User);

        }   
    }
}
