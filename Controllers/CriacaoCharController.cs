using harakiri_rpg.Models.DB;
using harakiri_rpg.Models.Pages.CriacaoChar;
using harakiri_rpg.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace harakiri_rpg.Controllers
{
    public class CriacaoCharController : Controller
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
                        })
             .OrderBy(x => x.id_char_tipo)
             .ToList();

            // Cria o modelo para enviar à view
            var model = new CriacaoCharViewModel
            {
                imgs = imgs
            };

            return View(model);
        }

    }
}
