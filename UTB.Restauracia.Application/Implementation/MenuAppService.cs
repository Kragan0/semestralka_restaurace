using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database;

namespace UTB.Restauracia.Application.Implementation
{
    public class MenuAppService : IMenuAppService
    {
        RestauraciaDbContext _restauraciaDbContext;
        public MenuAppService(RestauraciaDbContext restauraciaDbContext)
        {
            _restauraciaDbContext = restauraciaDbContext;
        }
        public IList<Menu> Select()
        {
            return _restauraciaDbContext.Menus.ToList();
        }
        public void Create(Menu menu)
        {

            _restauraciaDbContext.Menus.Add(menu);
            _restauraciaDbContext.SaveChanges();
        }
        public bool Delete(int id)
        {
            bool deleted = false;

            Menu? menu = _restauraciaDbContext.Menus.FirstOrDefault(prod => prod.Id == id);
            if (menu != null)
            {
                _restauraciaDbContext.Menus.Remove(menu);
                _restauraciaDbContext.SaveChanges();
                deleted = true;
            }
            return deleted;
        }
        
    }
}
