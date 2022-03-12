using BookStore.Models;
using BookStore.Utility.ConstantsStringSettings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Areas.Admin.Controllers
{
    [Area(UserAreas.Admin)]
    public class UsersController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public UsersController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return NotFound();

            var roles = await _roleManager.Roles.ToListAsync();

            var userRole = new UserRoles()
            {
                UserId = id,
                Roles = roles.Select(r => new Checkbox
                {
                    Value = r.Name,
                    Status = _userManager.IsInRoleAsync(user, r.Name).Result
                }).ToList()
            };

            return View(userRole);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(UserRoles userRoles)
        {
            var user = await _userManager.FindByIdAsync(userRoles.UserId);
            var oldRoles = await _userManager.GetRolesAsync(user);
            var newRoles = userRoles.Roles.Where(r => r.Status).Select(r => r.Value);

            await _userManager.RemoveFromRolesAsync(user, oldRoles);
            await _userManager.AddToRolesAsync(user, newRoles);

            return RedirectToAction(nameof(Index));
        }

        #region APIs
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var getUsers = await _userManager.Users.Select(u => new
            {
                UserId = u.Id,
                Username = u.UserName,
                u.Email
            }).ToListAsync();

            return Json(new { data = getUsers });
        }
        #endregion
    }
}
