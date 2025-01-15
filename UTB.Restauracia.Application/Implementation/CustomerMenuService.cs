using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.ViewModels;

namespace UTB.Restauracia.Application.Implementation
{
    public class CustomerMenuService : ICustomerMenuService
    {
        IFoodAppService _foodAppService;
        IMenuAppService _menuAppService;

        public CustomerMenuService(IFoodAppService foodAppService, IMenuAppService menuAppService)
        { 
            _foodAppService = foodAppService;
            _menuAppService = menuAppService;
        }

        public MenuViewModel GetCustomerMenuViewModel()
        {
            MenuViewModel menuViewModel = new MenuViewModel();
            menuViewModel.Foods = _foodAppService.Select();
            menuViewModel.Menus = _menuAppService.Select();
            return menuViewModel;
        }
    }
}
