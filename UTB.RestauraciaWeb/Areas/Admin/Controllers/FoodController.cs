using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using UTB.Restauracia.Infrastructure.Identity.Enums;
using UTB.RestauraciaWeb.Areas.Customer.Controllers;

namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class FoodController : Controller
    {
        IFoodAppService _foodAppService;

        public FoodController(IFoodAppService foodAppService)
        {
            _foodAppService = foodAppService;
        }


        public IActionResult Select()
        {
            IList<Food> foods = _foodAppService.Select();
            return View(foods);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var menus = _foodAppService.GetMenus();

            var viewModel = new FoodViewModel
            {
                menus = menus
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(FoodViewModel viewModel)
        {

                var food = new Food
                {
                    Name = viewModel.food.Name,
                    Description = viewModel.food.Description,
                    Price = viewModel.food.Price,
                    Image = viewModel.food.Image,
                    MenuId = viewModel.food.MenuId
                };

            if (ModelState.IsValid)
            {
                _foodAppService.Create(food);
                return RedirectToAction(nameof(FoodController.Select));

            }
            viewModel.menus = _foodAppService.GetMenus();

            return View(viewModel);

        }
        public IActionResult Delete(int id)
        {
            bool deleted = _foodAppService.Delete(id);
            if (deleted)
            {
                return RedirectToAction(nameof(FoodController.Select));
            }
            else
                return NotFound();
        } 
    }
}
