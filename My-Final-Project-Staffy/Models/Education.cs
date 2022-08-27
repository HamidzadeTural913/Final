using System.Collections.Generic;

namespace My_Final_Project_Staffy.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
