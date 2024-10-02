using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_clan_jutsu")]
    public class ClanJutsu
    {
        public int id_jutsu { get; set; }
        public int id_clan { get; set; }
    }
}
