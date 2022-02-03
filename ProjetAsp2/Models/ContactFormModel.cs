using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAsp2.Models
{
    public class ContactFormModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter full name")]
        [StringLength(30, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter subject")]
        [StringLength(30, MinimumLength = 3)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Not a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter message")]
        [StringLength(300, MinimumLength = 10)]
        public string Body { get; set; }
    }
}
