using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_kekkei_genkai")]
    public class KekkeiGenkai
    {
        public int id_kekkei_genkai { get; set; }
        public string nm_kekkei_genkai { get; set; }
        public int id_clan { get; set; }
        public string img_url_kekkei_genkai { get; set; }
    }
}
