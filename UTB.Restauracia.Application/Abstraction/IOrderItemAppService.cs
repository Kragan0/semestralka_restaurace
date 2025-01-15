using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IOrderItemAppService
    {
        IList<OrderItem> Select();
        void Create(OrderItem orderItems);
    }
}
