using EstevesRestaurant.data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstevesRestaurant.data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll(); //Give me all restaurants
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Remove(int id); 

    }
}
