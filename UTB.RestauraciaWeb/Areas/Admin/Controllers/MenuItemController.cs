using Microsoft.AspNetCore.Mvc;
namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemController : Controller
    {
        
        public IActionResult Select()
            { return View(); }

    }
}
