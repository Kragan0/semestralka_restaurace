using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Infrastructure.Database.Seeding
{
    internal class FoodInit
    {
        public IList<Food> GetMenuItems3()
        {
            // Get the initialized Menu object
            var foodInit = new MenuInit();
            var menus = foodInit.GetMenus3();

            // Assuming you want to use the first menu
            var menu = menus.First();


            IList<Food> foods = new List<Food>();

            foods.Add(new Food()
            {
                Id = 1,
                Name = "Bolongske Spagheti",
                Description = "Rezance s kečupom",
                Icon = "...",
                Price = 120.00,
                OrderItems = null,
                Favorites = null,
                MenuId = menu.Id,
                Menu = menu
            });

            foods.Add(new Food()
            {
                Id = 2,
                Name = "Pizza Margharita",
                Description = "Syrová pizza",
                Icon = "...",
                Price = 180.00,
                OrderItems = null,
                Favorites = null,
                MenuId = menu.Id,
                Menu = menu

            });

            foods.Add(new Food()
            {
                Id = 3,
                Name = "Bryndzové Halušky",
                Description = "Pravda, chvíľu treba žut, ale chutia príjemne",
                Icon = "...",
                Price = 240.00,
                OrderItems = null,
                Favorites = null,
                MenuId = menu.Id,
                Menu = menu

            });
            menu.Foods = foods;

            return foods;
        }
    }
}
