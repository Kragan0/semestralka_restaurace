
namespace UTB.Restauracia.Domain.Entities
{
    public class Menu
    {
        int Id { get; set; }
        public string Name { get; set; }

        public IList<Food> Foods { get; set; } = null;
    }
}
