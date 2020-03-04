using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;

namespace OdeToFoodCore
{
    public class detailsModel : PageModel
    {
        public Restaurant Restaurant { get; set; }
        public void OnGet(int restaurantid)
        {
            Restaurant = new Restaurant();
            Restaurant.Id = restaurantid;
        }
    }
}