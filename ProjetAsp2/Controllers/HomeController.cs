using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetAsp2.Data;
using ProjetAsp2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace ProjetAsp2.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IConfiguration _configuration)
        {
            _context = context;
            _logger = logger;
            Configuration = _configuration;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Driver;
            var applicationDbContext1= _context.Car;
            ViewBag.cars = applicationDbContext1;
            
            

            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }












        [HttpPost]
        public IActionResult Index(ContactFormModel model)
        {
            //Read SMTP settings from AppSettings.json.
            string host = this.Configuration.GetValue<string>("Smtp:Server");
            int port = this.Configuration.GetValue<int>("Smtp:Port");
            string fromAddress = this.Configuration.GetValue<string>("Smtp:FromAddress");
            string userName = this.Configuration.GetValue<string>("Smtp:UserName");
            string password = this.Configuration.GetValue<string>("Smtp:Password");

            using (MailMessage mm = new MailMessage(fromAddress, "ihebch947@gmail.com"))
            {
                mm.Subject = model.Subject;
                mm.Body = "Name: " + model.FullName + "<br /><br />Email: " + model.Email + "<br />" + model.Body;
                mm.IsBodyHtml = true;



                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = host;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    NetworkCredential NetworkCred = new NetworkCredential(userName, password);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = port;
                    smtp.Send(mm);
                    ViewBag.Message = "Email sent sucessfully.";
                }
            }

            return RedirectToAction(nameof(Index));
        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
