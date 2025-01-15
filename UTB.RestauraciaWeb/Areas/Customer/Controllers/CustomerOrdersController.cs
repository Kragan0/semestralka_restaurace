using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.Implementation;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Identity;
using UTB.Restauracia.Infrastructure.Identity.Enums;
using UTB.RestauraciaWeb.Areas.Admin.Controllers;

namespace UTB.RestauraciaWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = nameof(Roles.Customer))]
    public class CustomerOrdersController : Controller
    {

        ISecurityService _securityService;
        IOrderAppService _orderService;

        public CustomerOrdersController(ISecurityService securityService, IOrderAppService orderService)
        {
            _securityService = securityService;
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            User currentUser = await _securityService.GetCurrentUser(User);
            if (currentUser != null)
            {
                IList<Order> userOrders = _orderService.SelectForUser(currentUser.Id);
                return View(userOrders);
            }

            return NotFound();
        }
        public IActionResult Delete(int id)
        {
            bool deleted = _orderService.Delete(id);
            if (deleted)
            {
                
                return RedirectToAction(nameof(CustomerOrdersController.Index));
            }
            else
                return NotFound();
        }
    }
}