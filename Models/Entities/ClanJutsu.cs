using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_clan_jutsu")]
    public class ClanJutsu
    {
        public int id_jutsu { get; set; }
        public int id_clan { get; set; }
    }
}
