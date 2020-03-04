﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }


    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant(){Id = 1, Cuisine = CuisineType.Mexican, Location = "NY", Name = "Martin Sixers"},
                new Restaurant(){Id = 2, Cuisine = CuisineType.Nigerian, Location = "Abuja", Name = "Crunchies"},
                new Restaurant(){Id = 3, Cuisine = CuisineType.Italian, Location = "Toll troll", Name = "Uncle Ben"},
                new Restaurant(){Id = 4, Cuisine = CuisineType.Indian, Location = "Maryland", Name = "Scott Fries"},
                new Restaurant(){Id = 5, Cuisine = CuisineType.Nigerian, Location = "LG", Name = "Red Buffalos"}
            };
        }
        
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return restaurants.Where(x=>string.IsNullOrEmpty(name) || x.Name.StartsWith(name)).OrderBy(x=>x.Name);

        }
    }
}

