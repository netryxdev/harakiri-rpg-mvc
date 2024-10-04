using System.ComponentModel.DataAnnotations;

namespace ninja_br_rpg_MVC.Models.Pages.Cadastro
{
    public class CadastroViewModel
    {
        [Required]
        [Display(Name = "Nome de Usuário")]
        public string nm_usuario { get; set; } = string.Empty;

        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string nm_email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string nm_senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
        public string nm_senha_confirma { get; set; }
    }

}
