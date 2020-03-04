using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required, StringLength(100, ErrorMessage = "Maximum lenght of 100 cahracters"), MinLength(3, ErrorMessage = "Minimum of 3 characters")]
        public string Name { get; set; }

        [Required, StringLength(100, ErrorMessage = "Maximum lenght of 100 cahracters"),
         MinLength(2, ErrorMessage                = "Minimum of 3 characters")]

        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
