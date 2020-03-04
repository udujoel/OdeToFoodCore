using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFoodCore
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _iConfiguration;
        private readonly IRestaurantData _restaurantData;
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration iConfiguration, IRestaurantData RestaurantData)
        {
            _iConfiguration = iConfiguration;
            _restaurantData = RestaurantData;
            this._restaurantData = RestaurantData;


            Message = iConfiguration["message"];
            
        }
        public void OnGet(string searchTerm)
        {
            Message = _iConfiguration["message"];
            Restaurants = _restaurantData.GetRestaurantsByName(searchTerm);


        }
    }
}