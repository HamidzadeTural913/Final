using System.ComponentModel.DataAnnotations;

namespace My_Final_Project_Staffy.ViewModels
{
    public class EditUserVM
    {
        [Required, MaxLength(30)]
        public string FirstName { get; set; }

        [Required, MaxLength(30)]
        public string LastName { get; set; }
        [Required, MaxLength(30)]
        public string UserName { get; set; }

        [Required, DataType(DataType.EmailAddress), StringLength(50)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password),Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }
        
    }
}
