using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using UTB.Restauracia.Infrastructure.Identity.Enums;

namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class MenuController : Controller
    {
        IMenuAppService _menuAppService;

        public MenuController(IMenuAppService menuAppService)
        {
            _menuAppService = menuAppService;
        }
        public IActionResult Select()
        {
            IList<Menu> menus = _menuAppService.Select();
            return View(menus);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _menuAppService.Create(menu);
                return RedirectToAction(nameof(MenuController.Select));
            }
            return View();

        }

        public IActionResult Delete(int id)
        {
            bool deleted = _menuAppService.Delete(id);
            if (deleted)
            {
                return RedirectToAction(nameof(MenuController.Select));
            }
            else
                return NotFound();
        }
    }
}
