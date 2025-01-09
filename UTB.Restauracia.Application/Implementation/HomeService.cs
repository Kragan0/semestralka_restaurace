using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.ViewModels;

namespace UTB.Restauracia.Application.Implementation
{
    public class HomeService  
    {
        IFoodAppService _foodAppService;
        IMenuAppService _menuAppService;

        public HomeService(IFoodAppService foodAppService, IMenuAppService menuAppService)
        {
            this._foodAppService = foodAppService;
            this._menuAppService = menuAppService;
        }

        //public FoodViewModel GetIndexViewModel()
        //{
        //    FoodViewModel viewModel = new FoodViewModel();
        //    viewModel.food = _foodAppService.Select();
        //    viewModel.menus = _menuAppService.Select();
        //}

    }
}
