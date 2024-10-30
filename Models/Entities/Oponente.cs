using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_oponente")]
    public class Oponente
    {
        public int id_oponente { get; set; }
        public string nm_oponente { get; set; }
        public int lvl_oponente { get; set; }
        public int id_tipo_oponente { get; set; }
        public int recompensa_dinheiro { get; set; }
        public int recompensa_xp { get; set; }
        public string img_url_oponente { get; set; }
    }
}
