using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ninja_br_rpg_MVC.Models.DB.Entities;
using ninja_br_rpg_MVC.Models.Pages.UsuarioPerfil;

namespace ninja_br_rpg_MVC.Controllers
{
    public class UsuarioPerfilController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UsuarioPerfilController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var usuario = await _userManager.GetUserAsync(Usuario); // verificar como usar aqui 
            if (usuario == null)                                    // Ou usar procedure mesmo
            {
                return NotFound();
            }

            var model = new UsuarioPerfilViewModel
            {
                nm_usuario = usuario.nm_usuario,
                usuarioCharList = usuario.usuarioCharList,
            };

            return View(model);
        }
    }
}
