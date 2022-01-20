using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility.Seeds
{
    public static class DefaultUsers
    {
        public static async Task SeedBasicUserAsync(UserManager<IdentityUser> userManager)
        {
            var basicUser = new IdentityUser
            {
                UserName = "basic@bookstore.com",
                Email = "basic@bookstore.com",
                EmailConfirmed = true,
            };

            var userEmail = await userManager.FindByEmailAsync(basicUser.Email);
            if (userEmail == null)
            {
                await userManager.CreateAsync(basicUser, "P@ssword123");
                await userManager.AddToRoleAsync(basicUser, Roles.Basic.ToString());
            }
        }

        public static async Task SeedAdminUserAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManger)
        {
            var adminUser = new IdentityUser
            {
                UserName = "admin@bookstore.com",
                Email = "admin@bookstore.com",
                EmailConfirmed = true,
            };

            var userEmail = await userManager.FindByEmailAsync(adminUser.Email);
            if (userEmail == null)
            {
                await userManager.CreateAsync(adminUser, "P@ssword123");
                await userManager.AddToRoleAsync(adminUser, Roles.Admin.ToString());
            }

            await roleManger.SeedClaimsForAdminUser();
        }

        public static async Task SeedClaimsForAdminUser(this RoleManager<IdentityRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync(Roles.Admin.ToString());
            await roleManager.AddPermissionClaims(adminRole, Modules.Book.ToString());
        }

        public static async Task AddPermissionClaims(this RoleManager<IdentityRole> roleManager, IdentityRole role, string module)
        {
            var getRoleClaims = await roleManager.GetClaimsAsync(role);
            var allPermission = Permissions.GeneratePermissionsForModule(module);

            foreach (var permission in allPermission)
            {
                if (!getRoleClaims.Any(c => c.Type == Permissions.PERMISSION_TYPE && c.Value == permission))
                    await roleManager.AddClaimAsync(role, new Claim(Permissions.PERMISSION_TYPE, permission));                
            }
        }
    }
}
