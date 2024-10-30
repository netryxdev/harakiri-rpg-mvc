using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_oponente_atributo")]
    public class OponenteAtributo
    {
        public int id_oponente_atributo { get; set; }
        public int id_oponente { get; set; }
        public int vida { get; set; }
        public int chakra { get; set; }
        public int stamina { get; set; }
        public int forca { get; set; }
        public int inteligencia { get; set; }
        public int mentalidade { get; set; }
        public int def_fisica { get; set; }
        public int def_chakra { get; set; }
        public int def_mental { get; set; }
        public decimal precisao { get; set; }
        public decimal perfuracao { get; set; }
        public decimal critico { get; set; }
        public decimal evasao { get; set; }
    }
}
