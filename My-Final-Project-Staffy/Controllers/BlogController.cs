using Microsoft.AspNetCore.Mvc;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace My_Final_Project_Staffy.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page=1)
        {

            List<Blog> blogs = _context.Blogs.ToList();
            return View(blogs.ToPagedList(page,3));
        }
    }
}
        