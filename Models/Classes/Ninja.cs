using harakiri_rpg.Models.Classes;
using Microsoft.EntityFrameworkCore;

namespace harakiri_rpg.Models.Classes
{
    public class Ninja : BaseChar
    {
        public Ninja(int forca, int agilidade, int inteligencia)
        {
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            CalcularAtributosSecundarios();
        }

        public override void CalcularAtributosSecundarios()
        {
            // Cálculo dos atributos secundários do Ninja
            HP = 70 + (5 * Forca);
            AD = (int)(0.5 * Forca);
            AP = 30 + (3 * Inteligencia);
            DEF = 10 + (int)(0.5 * Forca);
            Spd = 25 + (3 * Agilidade);
            Energia = 50 + (5 * Inteligencia);

            // Cálculo de crítico e evasão
            Critico = 5 + (Agilidade / 5);
            Evasao = 3 + (Agilidade / 10);
        }
    }

}
