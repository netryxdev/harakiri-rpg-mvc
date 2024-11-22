using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_usuario_char")]
    public class UsuarioChar
    {
        [Key]
        public int id_usuario_char { get; set; }
        public int id_usuario { get; set; }
        public string nm_char { get; set; } = string.Empty;
        public int id_graduacao { get; set; } = 1;
        public int lvl_char { get; set; } = 1;
        public int xp_char { get; set; } = 0;
        public int id_char_tipo { get; set; }
        public bool dv_missao_andamento { get; set; } = false;
        public int? id_img_char { get; set; }
    }
}
