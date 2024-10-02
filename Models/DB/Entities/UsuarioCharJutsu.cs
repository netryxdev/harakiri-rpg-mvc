using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_usuario_char_jutsu")]
    public class UsuarioCharJutsu
    {
        public int id_usuario_char { get; set; }
        public int id_jutsu { get; set; }
    }
}
