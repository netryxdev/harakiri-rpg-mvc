using System.ComponentModel.DataAnnotations;

namespace harakiri_rpg.Models.Pages.Login
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuário")]
        public string nm_usuario { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string nm_senha { get; set; } = string.Empty;

        [Display(Name = "Lembrar-me")]
        public bool dv_lembrar { get; set; } = true;
    }

}
