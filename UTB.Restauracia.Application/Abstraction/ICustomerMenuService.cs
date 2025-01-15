using UTB.Restauracia.Application.ViewModels;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface ICustomerMenuService
    {
        public MenuViewModel GetCustomerMenuViewModel();

    }
}
