using Microsoft.AspNetCore.Mvc;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Linq;

namespace My_Final_Project_Staffy.Controllers
{
    public class AboutWAController : Controller
    {
        private readonly AppDbContext _context;

        public AboutWAController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<AboutWA> aboutWAs = _context.AboutWAs.ToList();
            return View(aboutWAs);
        }
    }
}
