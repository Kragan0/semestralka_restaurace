using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class MenuItemInit
    {
        public IList<MenuItem> GetMenuItems3()
        {
            IList<MenuItem> menuItems = new List<MenuItem>();

            menuItems.Add(new MenuItem()
            {
                Id = 1,
                Name = "Bolongske Spagheti",
                Description = "Rezance s kečupom",
                Icon = "...",
                Price = 120.00,
                OrderItems = null

            });

            menuItems.Add(new MenuItem()
            {
                Id = 2,
                Name = "Pizza Margharita",
                Description = "Syrová pizza",
                Icon = "...",
                Price = 180.00,
                OrderItems = null

            });

            menuItems.Add(new MenuItem()
            {
                Id = 3,
                Name = "Bryndzové Halušky",
                Description = "Pravda, chvíľu treba žut, ale chutia príjemne",
                Icon = "...",
                Price = 240.00,
                OrderItems = null

            });

            return menuItems;
        }
    }
}
