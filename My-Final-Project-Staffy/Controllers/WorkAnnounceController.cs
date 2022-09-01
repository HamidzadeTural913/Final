using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Controllers
{

    public class WorkAnnounceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public WorkAnnounceController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            List<Vacation> vacations = await _context.Vacations.Include(c=>c.State).ToListAsync();
            if(vacations==null) return NotFound();
            return View(vacations);
           
        }
    }
}
