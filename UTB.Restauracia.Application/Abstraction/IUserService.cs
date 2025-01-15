using UTB.Restauracia.Infrastructure.Identity;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IUserService
    {        
        public IList<User> SelectAll();
        public bool Delete(int id);
    }
}
