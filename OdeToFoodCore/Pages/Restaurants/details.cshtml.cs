using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFoodCore
{
    public class detailsModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        public Restaurant Restaurant { get; set; }

        public detailsModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaurantid)
        {
            
            
            Restaurant = _restaurantData.GetById(restaurantid);
            if (Restaurant ==null)
            {
                return RedirectToPage("./notfound");

            }
            
            return Page();
        }
    }
}