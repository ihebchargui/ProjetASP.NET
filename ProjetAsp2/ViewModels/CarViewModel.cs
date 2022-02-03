using Microsoft.AspNetCore.Http;
using ProjetAsp2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAsp2.ViewModels
{
    public class CarViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Nom { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Matricule { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Transmission { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Carburant { get; set; }
        public int NbSiege { get; set; }
        public int Prix { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Please choose car image")]
        [Display(Name = "Profile Picture")]
        public IFormFile CarPicture { get; set; }

        public virtual ICollection<RentCar> RentCars { get; set; }

    }
}
