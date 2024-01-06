using BlazorBlog.Shared.Data;
using BlazorBlog.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorBlog.Shared.Services.Server
{
    public class BasicSeedService : ISeedService
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public BasicSeedService(ApplicationDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task ManageDataAsync()
        {
            await _context.Database.MigrateAsync();

            await SeedDataAsync();
        }

        // Wrapper Method
        private async Task SeedDataAsync()
        {
            await SeedRolesAsync();
            await SeedUsersAsync();
        }

        private async Task SeedRolesAsync()
        {
            // Check Database for existing roles
            if (_context.Roles.Any()) return;

            // Create Necessary roles if they don't exist
            await _roleManager.CreateAsync(new IdentityRole("Administrator"));
            await _roleManager.CreateAsync(new IdentityRole("Creator"));
            await _roleManager.CreateAsync(new IdentityRole("Moderator"));
        }

        private async Task SeedUsersAsync()
        {
            if (_context.Users.Any()) return;

            // create Admin User
            var adminUser = new ApplicationUser()
            {
                Email = "elbie.smith@gmail.com",
                UserName = "elbie.smith@gmail.com",
                FirstName = "Elbie",
                LastName = "Smith",
                DisplayName = "IntrepidOwlbear",
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(adminUser, "Palad1ne!");
            await _userManager.AddToRoleAsync(adminUser, "Administrator");

            var modUser = new ApplicationUser()
            {
                Email = "CF.Moderator@Mailinator.com",
                UserName = "CF.Moderator@Mailinator.com",
                FirstName = "CoderFoundry",
                LastName = "ModTeam",
                DisplayName = "CFModerator",
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(modUser, "Abc&123!");
            await _userManager.AddToRoleAsync(modUser, "Moderator");
        }
    }
}