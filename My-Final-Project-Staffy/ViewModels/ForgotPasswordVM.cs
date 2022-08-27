using My_Final_Project_Staffy.Models;
using System.ComponentModel.DataAnnotations;

namespace My_Final_Project_Staffy.ViewModels
{
    public class ForgotPasswordVM
    {
        public AppUser AppUser { get; set; }

        public string Token { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
