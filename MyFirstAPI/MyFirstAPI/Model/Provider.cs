using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Model
{
    public class Provider
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The fild {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} need has between {2} and {1} caracters", MinimumLength = 2)]
        public string Name { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(14, ErrorMessage ="The field {0} need has between {2} and {1} caracters", MinimumLength = 2 )]
        public string Document { get; set; }

        public int TypeProvider { get; set; }
        public bool Activity { get; set; }

    }
}
