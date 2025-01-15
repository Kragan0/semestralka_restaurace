using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database.Configuration;

namespace UTB.Restauracia.Infrastructure.Database.Configuration.MySQL
{
    internal class OrderConfiguration : OrderConfigurationBase
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.Property(nameof(Order.OrderDate)).HasDefaultValueSql("NOW(6)");
        }
    }
}
