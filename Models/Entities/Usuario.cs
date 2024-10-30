
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_usuario")]
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string nm_usuario { get; set; } = string.Empty;
        public string nm_email { get; set; } = string.Empty;
        public string nm_senha { get; set; } = string.Empty;
        public string nr_celular { get; set; } = string.Empty;
    }
}
