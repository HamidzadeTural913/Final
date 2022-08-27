using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using My_Final_Project_Staffy.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Controllers
{
    public class ConstructCompanyController : Controller
    {
        private readonly AppDbContext _context;

        public ConstructCompanyController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.State = await _context.States.ToListAsync();
            ViewBag.Experience = await _context.Experiences.ToListAsync();
            ViewBag.Gender = await _context.Genders.ToListAsync();
            ViewBag.Education = await _context.Educations.ToListAsync();
            ViewBag.Work = await _context.WorkTables.ToListAsync();

            Vacation vacation = await _context.Vacations.Include(c => c.State).Include(x => x.Experience).Include(x => x.Gender).Include(c => c.Education).Include(x=>x.WorkTable).FirstOrDefaultAsync();

            return View(vacation);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Vacation vacation)
        {
            if (!ModelState.IsValid) return View();

            ViewBag.State = await _context.States.ToListAsync();
            ViewBag.Experience = await _context.Experiences.ToListAsync();
            ViewBag.Gender = await _context.Genders.ToListAsync();
            ViewBag.Education = await _context.Educations.ToListAsync();
            ViewBag.Work = await _context.WorkTables.ToListAsync();
            if (vacation == null) return NotFound();

            await _context.Vacations.AddAsync(vacation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
