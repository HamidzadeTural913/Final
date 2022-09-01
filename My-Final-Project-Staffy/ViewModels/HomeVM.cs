using My_Final_Project_Staffy.Models;
using System.Collections.Generic;

namespace My_Final_Project_Staffy.ViewModels
{
    public class HomeVM
    {
        public List<Vacation> Vacations { get; set; }
        public Vacation Vacation { get; set; }
        public List<Category> Category { get; set; }
        public List<Experience> Experience { get; set; }
        public List<Gender> Gender { get; set; }
        public List<State> State { get; set; }
        public List<WorkTable> WorkTable { get; set; }
        public List<Blog> Blogs { get; set; }
        public List <AboutWA> AboutWAs { get; set; }
        public List<AboutWE> AboutWEs { get; set; }
        public List<forService> forServices { get; set; }
        public List<AppUser> appUsers { get; set; }
        public List<Education> Educations { get; set; }
        public List<Com> Coms { get; set; }


    }

}
