using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TwaijriManagement.Domain.Models;
using TwaijriManagement.Persistence;

namespace TwaijriManagement.Installer
{
    public static class RegisterDependentServices
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            // Register your dependencies
            #region Data dependencies
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                            options.UseSqlServer(
                                builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region MVC dependencies
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            #endregion

            return builder;
        }
    }
}