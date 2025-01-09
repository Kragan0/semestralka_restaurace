using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Restauracia.Domain.Entities;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IRestaurantTableAppService
    {
        public IList<RestaurantTable> Select();

        public void Create(RestaurantTable restaurantTable);

        
    }
}
