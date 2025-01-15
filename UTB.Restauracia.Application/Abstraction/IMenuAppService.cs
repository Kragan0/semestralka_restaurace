
using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IMenuAppService
    {
        IList<Menu> Select();

        void Create(Menu menu);

        bool Delete(int id);
    }
}
