using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_missao_passiva_usuario_controle")]
    public class MissaoPassivaUsuarioControle
    {
        public int id_usuario_char { get; set; }
        public int id_missao { get; set; }
        public DateTime dt_inicio { get; set; }
        public DateTime dt_fim { get; set; }
    }
}
