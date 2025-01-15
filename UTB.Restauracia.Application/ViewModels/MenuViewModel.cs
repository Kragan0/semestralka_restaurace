using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.ViewModels
{
    public class MenuViewModel
    {
        public IList<Food>? Foods {  get; set; }
        public IList<Menu>? Menus { get; set; }
    }
}
