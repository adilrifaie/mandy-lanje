using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Infrastructure.Extensions;
public static class ApplicationExtension
{
    public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
    {
        RepositoryContext context = app
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<RepositoryContext>();

        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }
    }

    public static void ConfigureLocalization(this WebApplication app)
    {
        app.UseRequestLocalization(options =>
        {
            options.AddSupportedCultures("tr-TR")
                .AddSupportedUICultures("tr-TR")
                .SetDefaultCulture("tr-TR");
        });
    }

    public static async void ConfigureDefaultAdminUser(this IApplicationBuilder app)
    {
        IConfiguration configuration = app.ApplicationServices.GetRequiredService<IConfiguration>();
        string adminUser = configuration["DefaultAdmin:Username"] ?? "Admin";
        string adminPassword = configuration["DefaultAdmin:Password"] ?? "Admin123.";

        //User Manager
        UserManager<IdentityUser> userManager = app
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<UserManager<IdentityUser>>();

        //Role Manager
        RoleManager<IdentityRole> roleManager = app
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<RoleManager<IdentityRole>>();

        IdentityUser user = await userManager.FindByNameAsync(adminUser);

        if (user is null)
        {
            user = new IdentityUser(adminUser)
            {
                Email = "someone1@example.com",
                PhoneNumber = "05012345678",
                UserName = adminUser
            };

            var result = await userManager.CreateAsync(user, adminPassword);
            if (!result.Succeeded)
            {
                throw new Exception("Admin user could not be created.");
            }

            var roleResult = await userManager.AddToRolesAsync(user,
            /*new List<string>(){
                "Admin", "Editor", "User"
            }*/ roleManager.Roles.Select(r => r.Name).ToList());

            if (!roleResult.Succeeded)
            {
                throw new Exception("System roles could not be assigned to the Admin user.");
            }
        }
    }
}