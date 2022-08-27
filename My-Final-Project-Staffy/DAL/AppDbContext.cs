using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_Final_Project_Staffy.Models;

namespace My_Final_Project_Staffy.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<WorkTable> WorkTables { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AboutWA> AboutWAs { get; set; }
        public DbSet<AboutWE> AboutWEs { get; set; }
        public DbSet<forService> forServices { get; set; }
        public DbSet<WishListItem> WishListItems { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
