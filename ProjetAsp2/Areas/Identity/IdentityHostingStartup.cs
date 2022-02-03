using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetAsp2.Data;

[assembly: HostingStartup(typeof(ProjetAsp2.Areas.Identity.IdentityHostingStartup))]
namespace ProjetAsp2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProjetAsp2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProjetAsp2ContextConnection")));

               // services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                  //  .AddEntityFrameworkStores<ProjetAsp2Context>();
            });
        }
    }
}