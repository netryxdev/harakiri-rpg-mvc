using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_usuario_char_jutsu")]
    public class UsuarioCharJutsu
    {
        public int id_usuario_char { get; set; }
        public int id_jutsu { get; set; }
    }
}
