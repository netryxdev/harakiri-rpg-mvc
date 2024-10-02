using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_oponente_jutsu")]
    public class OponenteJutsu
    {
        public int id_oponente_jutsu { get; set; }
        public int id_oponente { get; set; }
        public int id_jutsu { get; set; }
    }
}
