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
            var imgs = _context.ImgsChar.AsNoTracking()
            .Where(x => x.dv_ativo == true) 
            .Select(z => new ImgCharViewModel 
            {
                id_char_tipo = z.id_char_tipo,
                nm_img_char = z.nm_img_char,
                url_img_char = z.url_img_char,
                nm_char_tipo = z.id_char_tipo == 1 ? "Ninja" : 
                    z.id_char_tipo == 2 ? "Samurai" : "Monge",
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
