using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database;


namespace UTB.Restauracia.Application.Implementation
{
    public class OrderAppService : IOrderAppService
    {
        RestauraciaDbContext _restauraciaDbConcext;
        public OrderAppService(RestauraciaDbContext restauraciaDbContext) 
        {
            _restauraciaDbConcext = restauraciaDbContext;
        }
        public IList<Order> Select()
        {
            return _restauraciaDbConcext.Orders.Include(oi => oi.User).ToList();
        }

        public IList<Order> SelectForUser(int userId)
        {
            return _restauraciaDbConcext.Orders.Where(or => or.UsertId == userId)
                                         .Include(o => o.User)
                                         .Include(o => o.OrderItems)
                                         .ThenInclude(oi => oi.Food)
                                         .ToList();
        }
        public void Create(Order order)
        {
            _restauraciaDbConcext.Orders.Add(order);
            _restauraciaDbConcext.SaveChanges();
        }
        public bool Delete(int id)
        {
            bool deleted = false;

            Order? order = _restauraciaDbConcext.Orders.FirstOrDefault(or => or.Id == id);
            if (order != null)
            {
                _restauraciaDbConcext.Orders.Remove(order);
                _restauraciaDbConcext.SaveChanges();
                deleted = true;
            }
            return deleted;
        }
    }
}
