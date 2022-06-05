using System;

namespace Aula06ParametrosRefOut
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculadora.Triplicar(ref a);
            Console.WriteLine(a);

            int b = 10;
            int duplicado;
            Calculadora.Duplicar(b, out duplicado);
            Console.WriteLine(duplicado);
        }
    }
}
