using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_missao_tipo")]
    public class MissaoTipo
    {
        public int id_missao_tipo { get; set; }
        public string nm_missao_tipo { get; set; }
    }
}
