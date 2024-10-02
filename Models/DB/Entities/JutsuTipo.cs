using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_jutsu_tipo")]
    public class JutsuTipo
    {
        public int id_jutsu_tipo { get; set; }
        public string nm_jutsu_tipo { get; set; }
    }
}
