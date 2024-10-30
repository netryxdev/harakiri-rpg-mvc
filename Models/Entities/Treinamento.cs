using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_treinamento")]
    public class Treinamento
    {
        public int id_treinamento { get; set; }
        public int id_usuario_char { get; set; }
        public int horas_treinadas { get; set; }
        public int xp_ganho { get; set; }
    }
}
