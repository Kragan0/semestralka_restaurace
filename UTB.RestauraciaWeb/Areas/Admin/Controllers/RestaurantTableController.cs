using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Identity.Enums;

namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class RestaurantTableController : Controller
    {
        IRestaurantTableAppService _restaurantTableAppService;

        public RestaurantTableController(IRestaurantTableAppService restaurantTableAppService)
        {
            _restaurantTableAppService = restaurantTableAppService;
        }
        public IActionResult Select()
        {
            IList<RestaurantTable> restaurantTables = _restaurantTableAppService.Select();
            return View(restaurantTables);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RestaurantTable restaurantTable)
        {
            if (ModelState.IsValid)
            {
                _restaurantTableAppService.Create(restaurantTable);
                return RedirectToAction(nameof(RestaurantTableController.Select));
            }
            return View();

        }

        public IActionResult Delete(int id)
        {
            bool deleted = _restaurantTableAppService.Delete(id);
            if (deleted)
            {
                return RedirectToAction(nameof(RestaurantTableController.Select));
            }
            else
                return NotFound();
        }
    }
}
