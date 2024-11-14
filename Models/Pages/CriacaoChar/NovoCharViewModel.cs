using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace harakiri_rpg.Models.Pages.CriacaoChar
{
    public class NovoCharViewModel
    {
        [DisplayName("Nome do Personagem"), Required]
        public string nm_char { get; set; } = string.Empty;

        [Required]
        public int id_char_tipo { get; set; }
        
        public int id_img_char { get; set; }

    }
}
