using harakiri_rpg.Models.DB;
using harakiri_rpg.Models.Entities;
using harakiri_rpg.Models.Pages.CriacaoChar;
using harakiri_rpg.Services.Interfaces;
using harakiri_rpg.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace harakiri_rpg.Controllers
{
    [Authorize]
    public class CriacaoCharController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public CriacaoCharController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tipos = _context.CharTipos.AsNoTracking();

            var imgs = (from img in _context.ImgsChar.AsNoTracking()
                        join tipo in tipos
                        on img.id_char_tipo equals tipo.id_char_tipo
                        where img.dv_ativo == true
                        select new ImgCharViewModel
                        {
                            id_char_tipo = img.id_char_tipo,
                            nm_img_char = img.nm_img_char,
                            url_img_char = img.url_img_char,
                            nm_char_tipo = tipo.nm_char_tipo, // Pega o valor do nome diretamente
                            nm_char_tipo_desc = tipo.nm_char_tipo_desc, // Pega o valor do nome diretamente
                        })
             .OrderBy(x => x.id_char_tipo)
             .ToList();

            var model = new CriacaoCharViewModel
            {
                imgs = imgs
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(NovoCharViewModel model)
        {
            try
            {
                if (!ModelState.IsValid || model is null)
                {
                    DisplayError(Messages.Error.GENERIC);
                }

                // Obter id_usuario do usuário autenticado
                var id_usuario = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "id_usuario")?.Value ?? "0");

                var usuario = _context.Usuarios.AsNoTracking().FirstOrDefault(x => x.id_usuario == id_usuario);

                var novo_char = new UsuarioChar
                {
                    id_usuario = id_usuario,
                    id_char_tipo = model!.id_char_tipo, // Fazer com que a index set o id_char_tipo selecionado
                    nm_char = model.nm_char,
                    id_graduacao = 0,
                    lvl_char = 0,
                    xp_char = 0,
                    dv_missao_andamento = false,
                    id_img_char = model.id_img_char
                };

                _context.UsuarioChars.Add(novo_char);
                _context.SaveChanges();

                DisplayMessage("Personagem criado com sucesso!");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                DisplayError(Messages.Error.GENERIC);
                return RedirectToAction("Index");
            }
        }

    }
}
