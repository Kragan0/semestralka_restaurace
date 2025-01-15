//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using UTB.Restauracia.Application.Abstraction;
//using UTB.Restauracia.Domain.Entities;
//using UTB.Restauracia.Infrastructure.Identity.Enums;
//using UTB.Restauracia.Infrastructure.Identity;
//using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

//using UTB.RestauraciaWeb.Controllers;

//namespace UTB.RestauraciaWeb.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class UserController : Controller
//    {
//        private IUserService _userService;
//        private ILogger _logger;
//        private UserManager<User> _userManager;
//        public UserController(IUserService userService, ILogger<UserController> logger, UserManager<User> userManager)
//        { 
//            _userService = userService;
//            _logger = logger;
//            _userManager = userManager;
//        }

//        [HttpGet("")]
//        public IActionResult Index()
//        {
//            // Check if the user is authenticated
//            if (!User.Identity.IsAuthenticated)
//            {
//                Console.WriteLine("User is not authenticated. Redirecting to login page.");
//                return Redirect("/");
//            }

//            // Check if the user has the Admin role
//            if (User.IsInRole(nameof(Roles.Admin)))
//            {
//                Console.WriteLine($"Admin user accessed the user management page: {User.Identity.Name}");

//                // Fetch all users from the service
//                IList<User> users = _userService.SelectAll();
//                return View(users);
//            }

//            // Redirect non-admin users to the feed page
//            Console.WriteLine($"Access denied for non-admin user: {User.Identity.Name}");
//            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace(nameof(Controller), String.Empty));
//        }

//        [HttpGet("Delete/{param1}")]
//        public async Task<IActionResult> Delete(int param1)
//        {
//            var user = await _userManager.FindByIdAsync(param1.ToString());
//            if (user == null)
//            {
//                Console.WriteLine("notfound");
//                return NotFound();
//            }

//            var result = await _userManager.DeleteAsync(user);
//            if (result.Succeeded)
//            {
//                return RedirectToAction(nameof(Index));
//            }

//            return View();
//        }
//    }
//}
