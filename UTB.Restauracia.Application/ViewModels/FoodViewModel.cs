using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.ViewModels
{
    public class FoodViewModel
    {
        public Food? food { get; set; } 
        public IList<Menu>? menus { get; set; }
        public IFormFile? Image { get; set; } // For file upload    
    }
}
