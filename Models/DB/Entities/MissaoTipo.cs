using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_missao_tipo")]
    public class MissaoTipo
    {
        public int id_missao_tipo { get; set; }
        public string nm_missao_tipo { get; set; }
    }
}
