using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_graduacao")]
    public class Graduacao
    {
        public int id_graduacao { get; set; }
        public string nm_graduacao { get; set; }
        public string nm_graduacao_desc { get; set; }
        public int lvl_graduacao { get; set; }
    }
}
