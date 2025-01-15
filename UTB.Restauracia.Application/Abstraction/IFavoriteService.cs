
using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IFavoriteService
    {
        public IList<Favorite> CustomerSelect(int userID);    
        public void AddFavorite(int userId, int foodId);
        public bool RemoveFavorite(int foodId);
    }
}
