using System;
using LPL.Areas.Identity.Data;
using LPL.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LPL.Areas.Identity.IdentityHostingStartup))]
namespace LPL.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RegisterContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RegisterContextConnection")));

                services.AddDefaultIdentity<RegisterUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddRoles<IdentityRole>().AddEntityFrameworkStores<RegisterContext>();
            });
        }
    }
}