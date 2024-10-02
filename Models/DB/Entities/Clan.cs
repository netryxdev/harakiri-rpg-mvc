using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_clan")]
    public class Clan
    {
        public int id_clan { get; set; }
        public string nm_clan { get; set; }
        public string nm_clan_desc { get; set; }
    }
}
