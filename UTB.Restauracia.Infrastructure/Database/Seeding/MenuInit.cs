
using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class MenuInit
    {
        public IList<Menu> GetMenus3()
        {
            IList<Menu> menus = new List<Menu>();
            menus.Add(new Menu()
            {
                Id = 1,
                Name = "Zakladne jedla"
            });

            return menus;
        }
    }
}
