using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_jutsu_tipo")]
    public class JutsuTipo
    {
        public int id_jutsu_tipo { get; set; }
        public string nm_jutsu_tipo { get; set; }
    }
}
