using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.Implementation;
using UTB.Restauracia.Application.ViewModels;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Identity;
using UTB.Restauracia.Infrastructure.Identity.Enums;
using UTB.RestauraciaWeb.Controllers;

namespace UTB.RestauraciaWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = nameof(Roles.Customer))]
    public class CustomerFavoritesController : Controller
    {
        IFavoriteService _favoriteAppService;
        ISecurityService _securityService;
        private readonly ICustomerMenuService _customerMenuService;

        public CustomerFavoritesController(IFavoriteService favoriteAppService, ISecurityService securityService, ICustomerMenuService customerMenuService)
        {
            _favoriteAppService = favoriteAppService;
            _securityService = securityService;
            _customerMenuService = customerMenuService;

        }
        [HttpPost]
        public async Task<IActionResult> AddFavorite(int foodId)
        {
            MenuViewModel viewModel = _customerMenuService.GetCustomerMenuViewModel();
            User currentUser = await _securityService.GetCurrentUser(User); // Ziskaj aktualneho pouzivatela
            if (currentUser != null)
            {
                _favoriteAppService.AddFavorite(currentUser.Id, foodId);
                return RedirectToAction(nameof(CustomerMenuController.RedirectToMenu));
            }
            return NotFound();
            
        }
        public async Task<IActionResult> Index()
        {
            User currentUser = await _securityService.GetCurrentUser(User); // Ziskaj aktualneho pouzivatela
            if (currentUser != null)
            {
                IList<Favorite> favorites = _favoriteAppService.CustomerSelect(currentUser.Id);
                return View(favorites);
            }
            return NotFound();

        }
    }
}
