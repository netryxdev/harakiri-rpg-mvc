using Microsoft.EntityFrameworkCore;

namespace ninja_br_rpg_MVC.Models.Personagens
{
    public class Monge : BaseChar
    {
        public Monge(int forca, int agilidade, int inteligencia)
        {
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            CalcularAtributosSecundarios();
        }

        public override void CalcularAtributosSecundarios()
        {
            // Cálculo dos atributos secundários do Monge
            HP = 150 + (15 * Forca);
            AD = 10 + (int)(1.5 * Forca);
            AP = 10 + (2 * Inteligencia);
            DEF = 30 + (2 * Forca);
            Spd = 10 + (1 * Agilidade);
            Energia = 30 + (3 * Inteligencia);

            // Cálculo de crítico e evasão
            Critico = 5 + (Agilidade / 15);
            Miss = 3 + (Agilidade / 30);
        }
    }

}
