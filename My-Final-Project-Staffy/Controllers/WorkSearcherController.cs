using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Controllers
{
    public class WorkSearcherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public WorkSearcherController(AppDbContext context,UserManager<AppUser>userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            List<AppUser> user = await _userManager.Users.ToListAsync();
            return View(user);
        }
    }
}
