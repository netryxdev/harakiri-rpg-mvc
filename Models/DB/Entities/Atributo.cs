using System.ComponentModel.DataAnnotations.Schema;

namespace ninja_br_rpg_MVC.Models.DB.Entities
{
    [Table("t_atributo")]
    public class Atributo
    {
        public int id_atributo { get; set; }
        public required string nm_atributo { get; set; }
        public string nm_atributo_desc {  get; set; }
        public string img_url_atributo { get; set; }
    }
}
