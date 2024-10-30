using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_ninja_tipo")]
    public class NinjaTipo
    {
        public int id_ninja_tipo { get; set; }
        public required string nm_ninja_tipo { get; set; }
    }
}
