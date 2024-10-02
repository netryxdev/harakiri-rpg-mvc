
using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_usuario")]
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nm_usuario { get; set; }
        public string nm_email { get; set; }
        //public string nm_senha { get; set; }
        public string nr_celular { get; set; }
    }
}
