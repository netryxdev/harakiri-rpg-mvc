using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_char_tipo")]
    public class CharTipo
    {
        [Key]
        public int id_char_tipo { get; set; }
        public string nm_char_tipo { get; set; } = string.Empty;
    }
}
