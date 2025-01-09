using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Application.ViewModels;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IHomeService
    {
        FoodViewModel GetIndexViewModel();        
    }
}
