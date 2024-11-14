using harakiri_rpg.Models.Entities;
using System.ComponentModel;

namespace harakiri_rpg.Models.Pages.CriacaoChar
{
    public class CriacaoCharViewModel
    {
        public List<ImgCharViewModel> imgs = new();
        public NovoCharViewModel NovoChar = new();
    }
}
