using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_tipo_oponente")]
    public class TipoOponente
    {
        public int id_tipo_oponente { get; set; }
        public string nm_tipo_oponente { get; set; }
    }
}
