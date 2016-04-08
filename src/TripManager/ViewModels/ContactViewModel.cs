using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripManager.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(300, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Message { get; set; }
    }
}
