using Microsoft.AspNetCore.Mvc;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;

namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        IReservationAppService _reservationAppService;

        public ReservationController(IReservationAppService reservationAppService)
        {
            _reservationAppService = reservationAppService;
        }

        public IActionResult Index()
        {
            IList<Reservation> reservations = _reservationAppService.Select();
            return View(reservations);
        }
    }
}
