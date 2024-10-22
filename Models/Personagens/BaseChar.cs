namespace ninja_br_rpg_MVC.Models.Personagens
{
    public abstract class BaseChar
    {
        // Atributos Primários
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }

        // Atributos Secundários calculados
        public int HP { get; protected set; } // Vida
        public int AD { get; protected set; } // Ataque Físico
        public int AP { get; protected set; } // Poder de Habilidade
        public int DEF { get; protected set; } // Defesa
        public int Miss { get; protected set; } // Chance de Evasão
        public int Critico { get; protected set; } // Chance de Crítico
        public int Spd { get; protected set; } // Velocidade
        public int Energia { get; protected set; } // Energia

        // Método para calcular os atributos secundários, a ser implementado pelas subclasses
        public abstract void CalcularAtributosSecundarios();
    }
}
