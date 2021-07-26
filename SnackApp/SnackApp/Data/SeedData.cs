// This class seed data to creates a SuperUser

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SnackApp.Data
{
    public static class SeedData
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider,
            IConfiguration configuration)
        {
            // Include customized profiles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            // Define profiles in an array of strings
            string[] roleNames = {"Admin", "Member"};
            IdentityResult roleResult;

            // Walks the profile string array
            // Verifies if the profile already exists
            foreach (var roleName in roleNames)
            {
                // Create the profiles and include the on the DataBase
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist) roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
            }

            // Creates a super user 
            var poweruser = new IdentityUser
            {
                // Get the name and email from the configuration file
                UserName = configuration.GetSection("UserSettings")["UserName"],
                Email = configuration.GetSection("UserSettings")["UserEmail"]
            };

            // Get the password from the configuration file
            var userPassword = configuration.GetSection("UserSettings")["UserPassword"];

            // Check if there is a user with the email entered
            var user = await UserManager.FindByEmailAsync(configuration.GetSection("UserSettings")["UserEmail"]);

            if (user == null)
            {
                // Create the super user with the data entered
                var createPowerUser = await UserManager.CreateAsync(poweruser, userPassword);
                if (createPowerUser.Succeeded)
                    // Assign the user to the Admin profile
                    await UserManager.AddToRoleAsync(poweruser, "Admin");
            }
        }
    }
}