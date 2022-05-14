using System;

namespace Aula08OperadoresRelacionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == Igual a
            // != Diferente de
            //  > Maior que
            //  < Menor que
            // >= Maior ou igual a
            // <= Menor ou igual a

            var valor1 = 10;
            var valor2 = 20;

            Console.WriteLine(valor1 == valor2);
            Console.WriteLine(valor1 != valor2);
            Console.WriteLine(valor1 > valor2);
            Console.WriteLine(valor1 <  valor2);
            Console.WriteLine(valor1 >= valor2);
            Console.WriteLine(valor1 <= valor2);
        }
    }
}
