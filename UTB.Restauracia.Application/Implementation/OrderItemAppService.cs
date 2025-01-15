using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database;

namespace UTB.Restauracia.Application.Implementation
{
    public class OrderItemAppService : IOrderItemAppService
    {
        RestauraciaDbContext _restauraciaDbContext;
        public OrderItemAppService(RestauraciaDbContext restauraciaDbContext)
        {
            _restauraciaDbContext = restauraciaDbContext;
        }

        public IList<OrderItem> Select()
        {
            return _restauraciaDbContext.OrderItems
                                        .Include(oi => oi.Food)
                                        .Include(oi => oi.Order)
                                        .ThenInclude(o => o.User)
                                        .OrderBy(oi => oi.Id)
                                        .ToList();
        }

        public void Create(OrderItem orderItem)
        {
            Order? order = _restauraciaDbContext.Orders.FirstOrDefault(o => o.Id == orderItem.OrderID);
            if (order != null)
            {
                order.TotalPrice += orderItem.Price;
                _restauraciaDbContext.OrderItems.Add(orderItem);
                _restauraciaDbContext.SaveChanges();
            }
        }
    }
}
