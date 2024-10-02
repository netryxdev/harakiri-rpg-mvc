using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_missao")]
    public class Missao
    {
        public int id_missao { get; set; }
        public int id_missao_tipo { get; set; }
        public string nm_missao { get; set; }
        public bool dv_passiva { get; set; } = false;
        public string nm_missao_desc { get; set; }
        public int lvl_missao { get; set; }
        public int xp_missao { get; set; }
        public decimal dinheiro_missao { get; set; } = 0;
        public TimeSpan Duration { get; set; }
        public int? id_oponente { get; set; }
    }
}
