using System.ComponentModel.DataAnnotations;

namespace harakiri_rpg.Models.Pages.Cadastro
{
    public class CadastroViewModel
    {
        [Required]
        [Display(Name = "Nome de Usuário")]
        public string nm_usuario { get; set; } = string.Empty;

        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string nm_email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string nm_senha { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [Compare("nm_senha", ErrorMessage = "As senhas não coincidem.")]
        public string nm_senha_confirma { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string nr_celular {  get; set; } = string.Empty;

    }

}
