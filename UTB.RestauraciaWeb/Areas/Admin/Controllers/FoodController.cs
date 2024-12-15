using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Application.Abstraction;


namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
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

    }
}
