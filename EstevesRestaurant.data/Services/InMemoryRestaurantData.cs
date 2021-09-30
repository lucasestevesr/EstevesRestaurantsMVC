using EstevesRestaurant.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstevesRestaurant.data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Esteves's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 2, Name = "Esteves's Bar", Cuisine = CuisineType.Brazilian},
                new Restaurant{Id = 3, Name = "Esteves's Burguer", Cuisine = CuisineType.American},
                new Restaurant{Id = 4, Name = "Esteves's Sushi", Cuisine = CuisineType.Japonese},
                new Restaurant{Id = 5, Name = "Esteves's Chili Pepper", Cuisine = CuisineType.Mexican}
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderByDescending(r => r.Name);
        }
                
        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }
        public void Remove(int id)
        {
            var restaurant = Get(id);
            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
        }

    }
}
