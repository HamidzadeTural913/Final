using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Extensions;
using My_Final_Project_Staffy.Models;
using My_Final_Project_Staffy.Utilities;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Areas.Staffy_Admin.Controllers
{
    [Area("Staffy-Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.ToListAsync();
            return View(blogs);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if(!ModelState.IsValid) return View();
            if(blog.Photo != null)
            {
                if (!blog.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Please choosed supported file");
                    return View();
                }

                
                blog.Image = await blog.Photo.FileCreate(_env.WebRootPath,@"assets\images");
                await _context.Blogs.AddAsync(blog); 
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file");
                return View();
            }
        }
        public async Task<IActionResult> Edit(int id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]  
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Blog blog)
        {
            Blog existedBlog = await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
            if (existedBlog == null) return NotFound();
            if(id != blog.Id) return BadRequest();
            existedBlog.Title = blog.Title;
            existedBlog.Subtitle = blog.Subtitle;
            existedBlog.Date = blog.Date;   
            await _context.SaveChangesAsync();  
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b=>b.Id == id);
            if(blog == null) return NotFound();     
            return View(blog);
        }
        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]
        
        public async Task<IActionResult> DeleteBlog(int id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
            if (blog == null) return NotFound();
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }  
    }
}



