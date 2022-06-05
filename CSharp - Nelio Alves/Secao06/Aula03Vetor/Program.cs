using System;
using System.Globalization;

namespace Aula03Vetor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas posições tem seu vetor: ");
            int quantidadeElementos = int.Parse(Console.ReadLine());

            double[] vetor = new double[quantidadeElementos];
            double soma = 0.0;

            for (int i = 0; i < quantidadeElementos; i++)
            {
                Console.WriteLine("Qual valor da posição " + i);
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vetor[i];
            }

            double media = soma / quantidadeElementos;

            Console.WriteLine("Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
