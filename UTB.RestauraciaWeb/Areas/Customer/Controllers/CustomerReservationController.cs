using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.Implementation;
using UTB.Restauracia.Application.ViewModels;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Identity;
using UTB.Restauracia.Infrastructure.Identity.Enums;
using UTB.RestauraciaWeb.Areas.Admin.Controllers;

namespace UTB.RestauraciaWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = nameof(Roles.Customer))]
    public class CustomerReservationController : Controller
    {
        IReservationAppService _reservationAppService;
        ISecurityService _securityService;
        public CustomerReservationController(IReservationAppService reservationAppService, ISecurityService securityService)
        {
            _securityService = securityService;
            _reservationAppService = reservationAppService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var restaurantTables = _reservationAppService.GetTables();
            var viewModel = new ReservationViewModel
            {
                restaurantTables = restaurantTables
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ReservationViewModel viewModel)
        {
            User currentUser = await _securityService.GetCurrentUser(User);
            var reservation = new Reservation
            {
                Time = viewModel.reservation.Time,
                NumberOfGuests = viewModel.reservation.NumberOfGuests,
                SpecialRequest = viewModel.reservation.SpecialRequest,
                TableId = viewModel.reservation.TableId,
                UserId = currentUser.Id

            };

            if (ModelState.IsValid)
            {
                _reservationAppService.Create(reservation);
                return RedirectToAction(nameof(CustomerReservationController.Index));
            }
            viewModel.restaurantTables = _reservationAppService.GetTables();
            return View(viewModel);

        }
        public async Task<IActionResult> Index()
        {
            User currentUser = await _securityService.GetCurrentUser(User);
            if (currentUser != null)
            {
                IList<Reservation> userReservations = _reservationAppService.SelectForUser(currentUser.Id);
                return View(userReservations);
            }

            return NotFound();
        }
        public IActionResult Delete(int id)
        {
            bool deleted = _reservationAppService.Delete(id);
            if (deleted)
            {
                return RedirectToAction(nameof(CustomerReservationController.Index));
            }
            else
                return NotFound();
        }
    }
}
