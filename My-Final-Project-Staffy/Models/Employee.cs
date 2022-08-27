namespace My_Final_Project_Staffy.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public int Expirience { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
