using Microsoft.AspNetCore.Mvc;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Linq;

namespace My_Final_Project_Staffy.Controllers
{
    public class ComController : Controller
    {
        private readonly AppDbContext _context;

        public ComController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Com> Coms = _context.Coms.ToList();
            return View(Coms);
        }
    }
}
