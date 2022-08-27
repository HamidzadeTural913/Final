using Microsoft.AspNetCore.Mvc;
using My_Final_Project_Staffy.DAL;

namespace My_Final_Project_Staffy.Controllers
{
    public class DetailWorkSearcherController : Controller
    {
        private readonly AppDbContext _context;

        public DetailWorkSearcherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
