using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_oponente_jutsu")]
    public class OponenteJutsu
    {
        public int id_oponente_jutsu { get; set; }
        public int id_oponente { get; set; }
        public int id_jutsu { get; set; }
    }
}
