using UTB.Restauracia.Infrastructure.Identity;
using UTB.Restauracia.Infrastructure.Database;
using UTB.Restauracia.Application.Abstraction;


namespace UTB.Restauracia.Application.Implementation
{
    public class UserService : IUserService
    {
        RestauraciaDbContext _restauraciaDbContext;
        private SecurityIdentityService _securityIdentityService;
        

        public UserService(RestauraciaDbContext restauraciaDbContext, SecurityIdentityService securityIdentity)
        {
            _restauraciaDbContext = restauraciaDbContext;
            _securityIdentityService = securityIdentity;
        }

        public IList<User> SelectAll()
        {
            return _restauraciaDbContext.Users.ToList();
        }
        public bool Delete(int id)
        {
            try
            {
                User userToDelete = _restauraciaDbContext.Users.Find(id);
                if (userToDelete != null)
                {
                    var orders = _restauraciaDbContext.Orders.Where(o => o.UsertId == id).ToList();
                    var reservations = _restauraciaDbContext.Reservations.Where(r => r.UserId == id).ToList();
                    _restauraciaDbContext.Orders.RemoveRange(orders);
                    _restauraciaDbContext.SaveChangesAsync();
                    _restauraciaDbContext.Reservations.RemoveRange(reservations);
                    _restauraciaDbContext.SaveChangesAsync();
                    _restauraciaDbContext.Remove(userToDelete);
                    _restauraciaDbContext.SaveChanges();
                    Console.WriteLine($"User with ID {id} deleted ");
                    return true;
                }
                else
                {
                    Console.WriteLine($"User with ID {id} not found");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while deleting user: {ex.Message}");
                return false;
            }
        }
    }
}
