using System.ComponentModel.DataAnnotations;

namespace ninja_br_rpg_MVC.Models.Pages.Login
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string nm_email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string nm_senha { get; set; } = string.Empty;

        [Display(Name = "E-mail")]
        public bool lembrar { get; set; }
    }

}
