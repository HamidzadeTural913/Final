using Microsoft.AspNetCore.Mvc;

namespace My_Final_Project_Staffy.Areas.Staffy_Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Staffy-Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
