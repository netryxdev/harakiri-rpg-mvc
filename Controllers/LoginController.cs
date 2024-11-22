using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using harakiri_rpg.Models.Pages.Login;
using harakiri_rpg.Models.DB;
using harakiri_rpg.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace harakiri_rpg.Controllers
{
    [AllowAnonymous]
    public class LoginController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly IUsuarioService _usuarioService;

        public LoginController(ApplicationDbContext context, IUsuarioService usuarioService)
        {
            _context = context;
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError(string.Empty, "Tentativa de login inválida.");
                    return View(model);
                }

                var usuario = _context.Usuarios.AsNoTracking().FirstOrDefault(x => x.nm_usuario == model.nm_usuario &&
                    x.nm_senha == model.nm_senha);

                if (usuario is null)
                {
                    DisplayError("Login e/ou Senha incorreto(s).");
                    return View(model);
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.nm_usuario),
                    new Claim("id_usuario", usuario.id_usuario.ToString()),
                    new Claim("nm_usuario", usuario.nm_usuario.ToString()),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = model.dv_lembrar // O cookie será persistente
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                DisplayMessage("Login Efetuado!");

                return RedirectToAction("Index", "CriacaoChar");
            }
            catch (Exception e)
            {
                DisplayError(e.Message);
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                DisplayMessage("Deslogado com sucesso!");
                return RedirectToAction("Index", "Login");
            }
            catch (Exception e)
            {
                DisplayError(e.Message);
                return RedirectToAction("Index");
            }
        }
    }
}
