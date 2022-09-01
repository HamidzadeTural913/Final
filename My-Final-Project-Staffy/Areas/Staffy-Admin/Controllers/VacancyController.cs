using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;

namespace My_Final_Project_Staffy.Areas.Staffy_Admin.Controllers
{
    [Area("Staffy-Admin")]
    public class VacancyController : Controller
    {
        private readonly AppDbContext _context;

        public VacancyController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Vacation> vacations = await _context.Vacations.ToListAsync();
            return View(vacations);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Vacation vacation = await _context.Vacations.FirstOrDefaultAsync(b => b.Id == id);
            if (vacation == null) return NotFound();
            return View(vacation);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Vacation vacation)
        {
            Vacation existedVacation = await _context.Vacations.FirstOrDefaultAsync(b => b.Id == id);
            if (existedVacation == null) return NotFound();
            if (id != vacation.Id) return BadRequest();

            existedVacation.IsChoosed = vacation.IsChoosed;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
