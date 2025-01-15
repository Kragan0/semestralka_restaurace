using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IOrderAppService
    {
        IList<Order> Select();
        IList<Order> SelectForUser(int userId);
        void Create(Order order);
        bool Delete(int id);
    }
}
