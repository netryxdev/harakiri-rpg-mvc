using harakiri_rpg.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using harakiri_rpg.Models.DB;
using harakiri_rpg.Models.Pages.UsuarioPerfil;

namespace harakiri_rpg.Controllers
{
    public class UsuarioPerfilController : BaseController
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UsuarioPerfilController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var usuario = await _userManager.GetUserAsync(Usuario); // verificar como usar aqui 
        //    if (usuario == null)                                    // Ou usar procedure mesmo
        //    {
        //        return NotFound();
        //    }

        //    var model = new UsuarioPerfilViewModel
        //    {
        //        nm_usuario = usuario.nm_usuario,
        //        usuarioCharList = usuario.usuarioCharList,
        //    };

        //    return View(model);
        //}
    }
}
