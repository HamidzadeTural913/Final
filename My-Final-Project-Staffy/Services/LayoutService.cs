using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<List<forService>> GetDatas()
        {
            return await _context.forServices.ToListAsync();
        }

        public async Task<AppUser> GetAppUser(string username)
        {
            AppUser user = await _userManager.Users.FirstOrDefaultAsync(x=>x.UserName==username);
            return user;
        }
    }
}
