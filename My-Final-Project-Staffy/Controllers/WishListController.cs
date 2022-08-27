using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Linq;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Controllers
{
    public class WishListController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public WishListController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
           _userManager = userManager;
        }
        public async Task<IActionResult> AddWishList(int id)
        {
           
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                WishListItem wishListItem = await _context.WishListItems.FirstOrDefaultAsync(b => b.Id == id && b.UserId == appUser.Id);
                if (wishListItem == null)
                {
                    WishListItem item = new WishListItem
                    {
                        User = appUser
                    };

                    _context.WishListItems.Add(item);
                   
                }
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index","Home");

        }
    }
}
