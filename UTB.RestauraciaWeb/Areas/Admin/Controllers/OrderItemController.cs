using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Identity.Enums;

namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class OrderItemController : Controller
    {
        IOrderItemAppService _orderItemService;
        IFoodAppService _foodService;
        IOrderAppService _orderService;
        public OrderItemController(IOrderItemAppService orderItemService, IFoodAppService foodService, IOrderAppService orderService)
        {
            _orderItemService = orderItemService;
            _foodService = foodService;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            IList<OrderItem> orderItems = _orderItemService.Select();
            return View(orderItems);
        }

        [HttpGet]
        public IActionResult Create()
        {
            SetOrderAndProductSelectLists();
            return View();
        }

        [HttpPost]
        public IActionResult Create(OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                _orderItemService.Create(orderItem);
                return RedirectToAction(nameof(OrderItemController.Index));
            }
            else
            { 
                return View(); 
            }
        }

        void SetOrderAndProductSelectLists()
        {
            IList<Food> foods = _foodService.Select();
            ViewData[nameof(OrderItem.FoodID)] = new SelectList(foods, nameof(Food.Id), nameof(Food.Name));

            IList<Order> orders = _orderService.Select();
            ViewData[nameof(OrderItem.OrderID)] = new SelectList(orders, nameof(Order.Id), nameof(Order.OrderNumber));

        }

    }
}
