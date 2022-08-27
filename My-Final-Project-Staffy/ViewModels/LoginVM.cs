using System.ComponentModel.DataAnnotations;

namespace My_Final_Project_Staffy.ViewModels
{
    public class LoginVM
    {
       
        [Required, StringLength(25)]
        public string UserName { get; set; }
        
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
