using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="The Title is required")]
        [StringLength(50,ErrorMessage ="The {0} must be at least {2} and max {1} characters",MinimumLength =3)]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Description is required")]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and max {1} characters", MinimumLength = 3)]
        public string Description { get; set; }

        [Required(ErrorMessage ="The Release Date is required")]
        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "The Author is required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "The Price is required")]
        public int Price { get; set; }
    }
}
