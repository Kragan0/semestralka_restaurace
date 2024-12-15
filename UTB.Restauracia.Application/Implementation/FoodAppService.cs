using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database;
namespace UTB.Restauracia.Application.Implementation
{
    public class FoodAppService : IFoodAppService
    {
        RestauraciaDbContext _restauraciaDbContext;
        public FoodAppService(RestauraciaDbContext restauraciaDbContext)
        {
            _restauraciaDbContext = restauraciaDbContext;
        }
        public IList<Food> Select()
        {
            return _restauraciaDbContext.Foods.ToList();
        }
    }
}