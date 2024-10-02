using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
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
