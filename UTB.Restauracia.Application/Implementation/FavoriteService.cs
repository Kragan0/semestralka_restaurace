using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Infrastructure.Identity;

namespace UTB.Restauracia.Application.Implementation
{
    public class FavoriteService : IFavoriteService
    {
        RestauraciaDbContext _restauraciaDbContext;
        public FavoriteService(RestauraciaDbContext restauraciaDbContext)
        {
            _restauraciaDbContext = restauraciaDbContext;
        }
        public IList<Favorite> CustomerSelect(int userId)
        {
            return _restauraciaDbContext.Favorites
            .Where(f => f.UserId == userId)
            .Include(f => f.Food)
            .ToList();
        }
        public void AddFavorite(int userId, int foodId)
        {
            var existingFavorite = _restauraciaDbContext.Favorites
                .FirstOrDefault(f => f.UserId == userId && f.FoodId == foodId);

            if (existingFavorite == null)
            {
                Favorite favorite = new Favorite
                {
                    UserId = userId,
                    FoodId = foodId
                };

                _restauraciaDbContext.Favorites.Add(favorite);
                _restauraciaDbContext.SaveChanges();
            }
        }
        public bool RemoveFavorite(int id)
        {
            bool deleted = false;
            Favorite? favorite = _restauraciaDbContext.Favorites.FirstOrDefault(fav => fav.Id == id);
            if (favorite != null)
            {
                _restauraciaDbContext.Favorites.Remove(favorite);
                _restauraciaDbContext.SaveChanges();
                deleted = true;
            }
            return deleted;

        }
    }
}
