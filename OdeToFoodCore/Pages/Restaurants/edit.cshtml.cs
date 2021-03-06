﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFoodCore
{
    public class editModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
       
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public editModel(IRestaurantData restaurantData, IHtmlHelper htmlHelper)
        {
            _restaurantData = restaurantData;
            this.Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
        }
        public IActionResult OnGet(int? restaurantid)
        {
            if (restaurantid.HasValue)
            {
                Restaurant = _restaurantData.GetById((int) restaurantid);
                if (Restaurant == null)
                {
                    return RedirectToPage("./notfound");
                }

            }
            else
            {
                Restaurant = new Restaurant();
                
            }


           


            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
               
            }

            if (Restaurant.Id >0)
            {
                var result = _restaurantData.Update(Restaurant);
                return RedirectToPage("details", new {restaurantid = Restaurant.Id});
            }
            
                _restaurantData.Add(Restaurant);



            return RedirectToPage("./list");



        }
    }
}