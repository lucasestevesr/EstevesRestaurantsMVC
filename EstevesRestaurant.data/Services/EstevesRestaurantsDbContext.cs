using EstevesRestaurant.data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstevesRestaurant.data.Services
{
    public class EstevesRestaurantsDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
