using harakiri_rpg.Models.Pages.Cadastro;

namespace harakiri_rpg.Services.Interfaces
{
    public interface IUsuarioService
    {
        void CriarUsuario(CadastroViewModel model);
    }
}
