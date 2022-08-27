using System.Collections.Generic;

namespace My_Final_Project_Staffy.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public byte VacationCount { get; set; }
        public List<Vacation> Vacations { get; set; }
    }
}
