using UTB.Restauracia.Application.ViewModels;
using UTB.Restauracia.Infrastructure.Identity.Enums;
namespace UTB.Restauracia.Application.Abstraction
{
    public interface IAccountService
    {
        Task<bool> Login(LoginViewModel vm);
        Task Logout();
        Task<string[]> Register(RegisterViewModel vm, params Roles[] roles);
    }
}
