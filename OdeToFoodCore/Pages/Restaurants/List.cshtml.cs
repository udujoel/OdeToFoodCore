using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFoodCore
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _iConfiguration;
        public string Message { get; set; }

        public ListModel(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;

            Message = iConfiguration["message"];
        }
        public void OnGet()
        {
            Message = _iConfiguration["message"];

        }
    }
}