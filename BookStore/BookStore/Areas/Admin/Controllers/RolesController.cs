using BookStore.Models;
using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Controllers
{
    [Area(UserAreas.Admin)]
    public class RolesController : Controller


    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [Authorize(ModulesPermissions.ROLES_VIEW)]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(ModulesPermissions.ROLES_CREATE)]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddRole(Role role)
        {
            if (ModelState.IsValid)
            {
                if (!await _roleManager.RoleExistsAsync(role.Name))
                    await _roleManager.CreateAsync(new IdentityRole(role.Name));
                else
                    TempData["Message"] = "Role is exist";

                return RedirectToAction(nameof(Index));
            }

            return View(role);
        }

        [Authorize(ModulesPermissions.ROLES_VIEW)]
        public async Task<IActionResult> ManagePermissions(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();

            var roleClaimsValues = _roleManager.GetClaimsAsync(role).Result.Select(c => c.Value);
            var allPermissions = Permissions.GenerateAllPermissions();

            var rolePermissions = new RolePermissions
            {
                RoleId = id,
                Modules = allPermissions.Select(p => p.Split('.')[1]).ToList(),
                Actions = allPermissions.Select(p => p.Split('.')[2]).ToList(),
                Permissions = allPermissions.Select(p => new Checkbox
                {
                    Value = p,
                    Status = roleClaimsValues.Contains(p)
                }).ToList()
            };

            return View(rolePermissions);
        }

        [Authorize(ModulesPermissions.ROLES_UPDATE)]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Save(RolePermissions rolePermissions)
        {
            var role = await _roleManager.FindByIdAsync(rolePermissions.RoleId);
            if (role == null)
                return NotFound();

            var oldClaims = await _roleManager.GetClaimsAsync(role);
            var newClaims = rolePermissions.Permissions.Where(p => p.Status).Select(p => new Claim("Permission", p.Value)).ToList();

            foreach (var claim in oldClaims)
                await _roleManager.RemoveClaimAsync(role, claim);

            foreach (var claim in newClaims)
                await _roleManager.AddClaimAsync(role, claim);

            return RedirectToAction(nameof(Index));
        }

        #region API's
        public async Task<IActionResult> GetRoles()
        {
            var getRoles = await _roleManager.Roles.Select(r => new
            {
                RoleId = r.Id,
                RoleName = r.Name,
            }).ToListAsync();

            return Json(new { data = getRoles });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return Json(new { success = false });

            await _roleManager.DeleteAsync(role);
            return Json(new { success = true });
        }
        #endregion
    }
}
