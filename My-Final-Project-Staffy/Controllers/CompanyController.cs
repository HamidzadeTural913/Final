using Microsoft.AspNetCore.Mvc;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;

namespace My_Final_Project_Staffy.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AppDbContext _context;

        public CompanyController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Company> companies = await _context.Companies.ToListAsync();
            return View(companies);
        }
    }
}
