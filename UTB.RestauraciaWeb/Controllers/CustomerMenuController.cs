using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.ViewModels;

namespace UTB.RestauraciaWeb.Controllers
{
    public class CustomerMenuController : Controller
    {
        private readonly ICustomerMenuService _customerMenuService;

        public CustomerMenuController(ICustomerMenuService customerMenuService)
        {
            _customerMenuService = customerMenuService;
        }

        public IActionResult RedirectToMenu()
        {
            MenuViewModel viewModel = _customerMenuService.GetCustomerMenuViewModel();

            return View("~/Views/Home/Menu.cshtml", viewModel);
        }
    }
}
