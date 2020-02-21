using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFoodCore
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Hello world";

        }
    }
}