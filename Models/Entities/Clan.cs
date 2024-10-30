using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_clan")]
    public class Clan
    {
        public int id_clan { get; set; }
        public string nm_clan { get; set; }
        public string nm_clan_desc { get; set; }
    }
}
