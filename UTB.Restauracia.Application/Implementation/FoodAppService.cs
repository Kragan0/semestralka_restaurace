﻿using System.Runtime.InteropServices;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.ViewModels;
using UTB.Restauracia.Domain.Entities;
using UTB.Restauracia.Infrastructure.Database;
namespace UTB.Restauracia.Application.Implementation
{
    public class FoodAppService : IFoodAppService
    {
        RestauraciaDbContext _restauraciaDbContext;
        public FoodAppService(RestauraciaDbContext restauraciaDbContext)
        {
            _restauraciaDbContext = restauraciaDbContext;
        }
        public IList<Food> Select()
        {
            return _restauraciaDbContext.Foods.ToList();
        }
        public void Create(Food food)
        {

            _restauraciaDbContext.Foods.Add(food);
            _restauraciaDbContext.SaveChanges();
        }
        public IList<Menu> GetMenus()
        {
            return _restauraciaDbContext.Menus.ToList();
        }
        public bool Delete(int id)
        {
            bool deleted = false;
            
            Food? food = _restauraciaDbContext.Foods.FirstOrDefault(prod => prod.Id == id);
            if (food != null)
            {
                _restauraciaDbContext.Foods.Remove(food);
                _restauraciaDbContext.SaveChanges();
                deleted = true;
            }
            return deleted;
        }

    }
}