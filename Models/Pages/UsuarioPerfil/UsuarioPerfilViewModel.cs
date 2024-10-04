using ninja_br_rpg_MVC.Models.DB.Entities;

namespace ninja_br_rpg_MVC.Models.Pages.UsuarioPerfil
{
    public class UsuarioPerfilViewModel
    {
        public string nm_usuario { get; set; } = string.Empty;
        public List<UsuarioChar> usuarioCharList { get; set; } = new();
    }
}
