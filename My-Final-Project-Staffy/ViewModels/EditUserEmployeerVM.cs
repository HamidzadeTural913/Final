using System.ComponentModel.DataAnnotations;

namespace My_Final_Project_Staffy.ViewModels
{
    public class EditUserEmployeerVM
    {
        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress), StringLength(50)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password), Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber), StringLength(12)]
        public string PhoneNumber { get; set; }
        [MaxLength(30)]
        public string Company { get; set; }
        [MaxLength(30)]
        public string CompanySite { get; set; }
        public bool IsEmployer { get; set; } = true;
    }
}
