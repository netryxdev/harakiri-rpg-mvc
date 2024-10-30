using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_tipo_oponente")]
    public class TipoOponente
    {
        public int id_tipo_oponente { get; set; }
        public string nm_tipo_oponente { get; set; }
    }
}
