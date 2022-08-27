using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace My_Final_Project_Staffy.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEmpolyeer { get; set; }
        public string Company { get; set; }
        public string CompanyWebSite { get; set; }
        public List<Employee> Employees { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSuperAdmin { get; set; }

    }
}
