using Microsoft.AspNetCore.Mvc;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Linq;

namespace My_Final_Project_Staffy.Controllers
{
    public class AboutWEController : Controller
    {
        private readonly AppDbContext _context;

        public AboutWEController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<AboutWE> aboutWEs = _context.AboutWEs.ToList();
            return View(aboutWEs);
        }
    }
}
