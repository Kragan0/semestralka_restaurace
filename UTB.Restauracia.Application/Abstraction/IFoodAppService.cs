using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IFoodAppService
    {
        IList<Food> Select();

        void Create(Food food);

        IList<Menu> GetMenus();

        bool Delete(int id);
    }
}