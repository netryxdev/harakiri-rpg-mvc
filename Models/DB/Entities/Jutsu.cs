using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_jutsu")]
    public class Jutsu
    {
        public int id_jutsu { get; set; }
        public string nm_jutsu { get; set; }
        public int id_jutsu_tipo { get; set; }
        public int custo_jutsu { get; set; }
        public string nm_jutsu_desc { get; set; }
        public int dano_jutsu { get; set; } = 0;
        public decimal precisao_jutsu { get; set; } = 0;
        public bool dv_oponente { get; set; } = false;
        public bool dv_jutsu_passivo { get; set; } = false;
        public bool dv_exclusivo_clan { get; set; } = false;
        public bool dv_exclusivo_portao { get; set; } = false;
        public bool dv_exclusivo_tipo { get; set; } = false;
    }
}
