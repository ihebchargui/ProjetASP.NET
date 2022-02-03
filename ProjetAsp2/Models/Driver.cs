using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAsp2.Models
{
    public class Driver
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "First Name")]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last Name")]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter adresse")]
        [StringLength(30, MinimumLength = 3)]
        public string Adresse { get; set; }
        [Required(ErrorMessage = "Please enter salary")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "Please enter age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Please choose driver image")]
        public string DriverPicture { get; set; }


        public Driver()
        {
            FullName = FirstName + " " + LastName;
        }
    }
}
