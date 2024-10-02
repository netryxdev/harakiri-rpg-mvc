using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_ninja_tipo")]
    public class NinjaTipo
    {
        public int id_ninja_tipo { get; set; }
        public required string nm_ninja_tipo { get; set; }
    }
}
