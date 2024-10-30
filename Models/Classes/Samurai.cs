using harakiri_rpg.Models.Classes;

namespace harakiri_rpg.Models.Classes
{
    public class Samurai : BaseChar
    {
        public Samurai(int forca, int agilidade, int inteligencia)
        {
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            CalcularAtributosSecundarios();
        }

        public override void CalcularAtributosSecundarios()
        {
            // Cálculo dos atributos secundários do Samurai
            HP = 100 + (10 * Forca);
            AD = 25 + (2 * Forca);
            AP = (int)(0.5 * Inteligencia);
            DEF = 20 + (1 * Forca);
            Spd = 15 + (2 * Agilidade);
            Energia = 20 + (2 * Inteligencia);

            // Cálculo de crítico e evasão
            Critico = 5 + (Agilidade / 10);
            Evasao = 3 + (Agilidade / 20);
        }
    }
}
