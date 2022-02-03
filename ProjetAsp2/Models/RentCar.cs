using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAsp2.Models
{
    public class RentCar
    {
        public int Id { get; set; }




        [Required(ErrorMessage = "Please enter full name")]
        [Display(Name = "Full Name")]
        [StringLength(30, MinimumLength = 6)]
        public string FullName { get; set; }


        [Required(ErrorMessage = "Please enter adresse")]
        [StringLength(30, MinimumLength = 3)]
         public string Adresse { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Not a valid email")]
         public string Email { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        [DataType(DataType.PhoneNumber)]
         public string Tel { get; set; }

        [Display(Name = "StartDate")]
         public DateTime StartDate { get; set; }

        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }


        [Display(Name = "Car")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Display(Name = "Driver")]
        public int DriverId { get; set; }
        public virtual Driver driver { get; set; }

    }
}
