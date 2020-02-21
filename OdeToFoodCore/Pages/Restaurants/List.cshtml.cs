using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFoodCore
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }

        public ListModel(IConfiguration iConfiguration)
        {
            Message = iConfiguration["message"];
        }
        public void OnGet()
        {
            //            Message = "Hello world";

        }
    }
}