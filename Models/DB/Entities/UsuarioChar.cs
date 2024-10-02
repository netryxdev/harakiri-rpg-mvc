using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_usuario_char")]
    public class UsuarioChar
    {
        public int id_usuario_char { get; set; }
        public int id_usuario { get; set; }
        public string nm_char { get; set; }
        public int id_graduacao { get; set; } = 1;
        public int lvl_char { get; set; } = 1;
        public int xp_char { get; set; } = 0;
        public int id_ninja_tipo { get; set; }
        public int? id_clan { get; set; }
        public int? id_kekkei_genkai { get; set; }
        public bool dv_portao { get; set; } = false;
        public bool dv_missao_andamento { get; set; } = false;
    }
}
