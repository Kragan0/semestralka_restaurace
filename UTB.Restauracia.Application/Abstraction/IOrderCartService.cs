using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Abstraction
{
     public interface IOrderCartService
    {
        double AddOrderItem(int? foodId, List<OrderItem> orderItems, double totalPrice);
        bool ApproveOrder(int userId, List<OrderItem> orderItems, double totalPrice);
    
    }
}
