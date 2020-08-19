using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PioPage.Areas.Identity.Data;
using PioPage.Data;

[assembly: HostingStartup(typeof(PioPage.Areas.Identity.IdentityHostingStartup))]
namespace PioPage.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PioPageContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PioPageContextConnection")));

                services.AddDefaultIdentity<PioPageUser>(options =>
                    {
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                        options.SignIn.RequireConfirmedAccount = false;
                    })
                    .AddEntityFrameworkStores<PioPageContext>();
            });
        }
    }
}