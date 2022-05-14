using System;

namespace Aula06IncrementoDecremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, total;

            valor1 = 50;
            valor2 = 40;

            total = valor1 + valor2;

            total++;
            total--;

            Console.WriteLine("Total é de {0}", total);
        }
    }
}
