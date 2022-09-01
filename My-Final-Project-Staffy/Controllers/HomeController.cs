using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using My_Final_Project_Staffy.ViewModels;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Vacations = await _context.Vacations.Include(c=>c.AppUser).ToListAsync(),
                Category = await _context.Categories.ToListAsync(),
                Experience = await _context.Experiences.ToListAsync(),
                Gender = await _context.Genders.ToListAsync(),
                State = await _context.States.ToListAsync(),
                WorkTable = await _context.WorkTables.ToListAsync(),
                AboutWAs = await _context.AboutWAs.ToListAsync(),
                forServices = await _context.forServices.ToListAsync(),
                Coms = await _context.Coms.ToListAsync(),
            };
            return View(model);

        }
    }
}
