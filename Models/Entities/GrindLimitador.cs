using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_grind_limitador")]
    public class GrindLimitador
    {
        public int id_usuario_char { get; set; }
        public int id_oponente { get; set; }
        public DateTime dt_ultima_batalha { get; set; }
        public int tentativas_restantes { get; set; } = 5;
    }
}
