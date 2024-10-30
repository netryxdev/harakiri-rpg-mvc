using harakiri_rpg.Models.DB;
using System.Text;
using harakiri_rpg.Models.Entities;
using harakiri_rpg.Services.Interfaces;
using harakiri_rpg.Models.Pages.Cadastro;

namespace harakiri_rpg.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _context;

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CriarUsuario(CadastroViewModel model)
        {
            var user = new Usuario
            {
                nm_usuario = model.nm_usuario,
                nm_email = model.nm_email,
                nm_senha = model.nm_senha,
            };

            _context.Usuarios.Add(user);
            _context.SaveChanges();
        }

        //private string HashPassword(string password)
        //{
        //    using (var sha256 = SHA256.Create())
        //    {
        //        var bytes = Encoding.UTF8.GetBytes(password);
        //        var hash = sha256.ComputeHash(bytes);
        //        return Convert.ToBase64String(hash);
        //    }
        //}
    }
}
