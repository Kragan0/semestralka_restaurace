using UTB.Restauracia.Infrastructure.Database;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Implementation
{
    public class OrderCartService : IOrderCartService
    {
        RestauraciaDbContext _restauraciaDbContext;

        public OrderCartService(RestauraciaDbContext restauraciabContext)
        {
            _restauraciaDbContext = restauraciabContext;
        }


        public double AddOrderItem(int? foodId, List<OrderItem> orderItems, double totalPrice)
        {
            
            Food? food = _restauraciaDbContext.Foods.FirstOrDefault(f => f.Id == foodId);

            if (food != null)
            {
                //find the order item with the FoodID (if exists)
                OrderItem? orderItemInList = orderItems.FirstOrDefault(oi => oi.FoodID == food.Id);

                //if there is order item with FoodID, increase amount and price, otherwise, add new OrderItem
                if (orderItemInList != null)
                {
                    ++orderItemInList.Amount;
                    orderItemInList.Price += food.Price;
                }
                else
                {
                    //create order item with connected product and add it to the list
                    OrderItem orderItem = new OrderItem()
                    {
                        FoodID = food.Id,
                        Food = food,
                        Amount = 1,
                        Price = food.Price
                    };

                    orderItems.Add(orderItem);
                }

                //increase the total price and set it to the session
                totalPrice += food.Price;
            }

            //return total price
            return totalPrice;
        }


        public bool ApproveOrder(int userId, List<OrderItem> orderItems, double totalPrice)
        {
            if (orderItems != null)
            {
                
                orderItems.ForEach(orderItem => orderItem.Food = null);

                Order order = new Order()
                {
                    OrderNumber = Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                    TotalPrice = totalPrice,
                    OrderItems = orderItems,
                    UsertId = userId,
                    
                    
                };

                
                _restauraciaDbContext.Add(order);
                _restauraciaDbContext.SaveChanges();


                //success
                return true;

            }

            //failure
            return false;
        }

    }
}
