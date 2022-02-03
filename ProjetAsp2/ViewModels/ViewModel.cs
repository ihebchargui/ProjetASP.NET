using ProjetAsp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAsp2.ViewModels
{
    public class ViewModel
    {
        public IEnumerable<Driver> Drivers { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
