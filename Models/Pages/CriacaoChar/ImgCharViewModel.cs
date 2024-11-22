using System.ComponentModel.DataAnnotations;

namespace harakiri_rpg.Models.Pages.CriacaoChar
{
    public class ImgCharViewModel
    {
        public int id_char_tipo { get; set; }
        public string nm_img_char { get; set; } = string.Empty;
        public string url_img_char { get; set; } = string.Empty;
        public string nm_char_tipo { get; set; } = string.Empty;
        public string nm_char_tipo_desc { get; set; } = string.Empty;
    }
}
