using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_img_char")]
    public class ImgChar
    {
        [Key]
        public int id_img_char { get; set; }
        public string nm_img_char { get; set; } = string.Empty;
        public string url_img_char { get; set; } = string.Empty;
        public bool dv_ativo { get; set; }
        public int id_char_tipo { get; set; }
    }
}
