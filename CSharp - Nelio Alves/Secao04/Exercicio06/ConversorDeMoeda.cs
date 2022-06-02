namespace Exercicio06
{
    public class ConversorDeMoeda
    {
        static public double Cotacao;

        static public double MoedaDolar;

        static public double Conversor()
        {
            double total = Cotacao * MoedaDolar;
            return (total + (total * 0.06));
        }
    }
}
