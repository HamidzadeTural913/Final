using System.ComponentModel.DataAnnotations;

namespace My_Final_Project_Staffy.Models
{
    public class Vacation
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public byte MinAge { get; set; }
        public byte MaxAge { get; set; }
        public string Region { get; set; }
        public string Adress { get; set; }
        public string Ability { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public string Description { get; set; }
        [Required, DataType(DataType.EmailAddress), StringLength(50)]
        public string Email { get; set; }
        [Required, DataType(DataType.PhoneNumber), StringLength(20)]
        public string Phone { get; set; }
        public string Information { get; set; }
        public bool IsChoosed { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int WorkTableId { get; set; }
        public WorkTable WorkTable { get; set; }
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public Education Education { get; set; }
        public int? EducationId { get; set; }

        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }


    }
}
