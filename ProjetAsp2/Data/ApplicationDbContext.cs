using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetAsp2.Models;

namespace ProjetAsp2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjetAsp2.Models.ProjectRole> ProjectRole { get; set; }
       
        public DbSet<ProjetAsp2.Models.Car> Car { get; set; }
       
        public DbSet<ProjetAsp2.Models.Driver> Driver { get; set; }
       
        public DbSet<ProjetAsp2.Models.RentCar> RentCar { get; set; }
        public DbSet<ProjetAsp2.Models.ContactFormModel> ContactFormModel { get; set; }


    }
}
