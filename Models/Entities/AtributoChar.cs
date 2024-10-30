﻿using System.ComponentModel.DataAnnotations.Schema;

namespace harakiri_rpg.Models.Entities
{
    [Table("t_atributo")]
    public class AtributoChar
    {
        public int id_atributo_char { get; set; }
        public int id_usuario_char { get; set; }
        public int vida { get; set; }
        public int chakra { get; set; }
        public int stamina { get; set; }
        public int energia { get; set; }
        public int forca { get; set; }
        public int inteligencia { get; set; }
        public int mentalidade { get; set; }
        public int def_fisica { get; set; }
        public int def_chakra { get; set; }
        public int def_mental { get; set; }
        public int precisao { get; set; }
        public int perfuracao { get; set; }
        public decimal critico { get; set; }
        public int evasao { get; set; }
    }
}
