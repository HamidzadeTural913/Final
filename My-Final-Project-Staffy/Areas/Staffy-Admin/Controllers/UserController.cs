using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.Models;
using My_Final_Project_Staffy.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Areas.Staffy_Admin.Controllers
{
    [Area("Staffy-Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Users()
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();

            return View(users);
        }
        public async Task<IActionResult> AppointRole(string id)
        {
            AppUser user = await _userManager.Users.FirstOrDefaultAsync(i => i.Id == id);
            if (user == null) return NotFound();

            return View(user);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> AppointRole(string id, AppUser user)
        {
            AppUser existed = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (existed == null) return NotFound();

            if (user.IsAdmin)
            {
                await _userManager.AddToRoleAsync(existed, Roles.Admin.ToString());
            }
            if (user.IsSuperAdmin)
            {
                await _userManager.AddToRoleAsync(existed, Roles.SuperAdmin.ToString());
            }
            existed.IsSuperAdmin = user.IsSuperAdmin;
            existed.IsAdmin = user.IsAdmin;
            await _userManager.UpdateAsync(existed);
            return RedirectToAction(nameof(Users));
        }
    }
}
