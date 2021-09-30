using EstevesRestaurant.data.Models;
using EstevesRestaurant.data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EstevesRestaurant.Web.Api
{
    public class RestaurantsController : ApiController
    {
        private IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }

        public  IEnumerable<Restaurant> Get() 
        {
            var model = db.GetAll();
            return model;
        }
    }
}
