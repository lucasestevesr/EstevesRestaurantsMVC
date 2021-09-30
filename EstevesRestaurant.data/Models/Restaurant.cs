﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstevesRestaurant.data.Models
{
    // This Model Class => Entity (Because represents information thats going to be persisted into a db)
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Display(Name =  "Type of Food")]
        public CuisineType Cuisine { get; set; }
    }
}
