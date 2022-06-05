namespace Aula06ParametrosRefOut
{
    public class Calculadora
    {
        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }

        public static void Duplicar(int origem, out int resultado)
        {
            resultado = origem * 2;
        }
    }
}
