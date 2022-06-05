using System;
using System.Globalization;

namespace Aula04Vetor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas posições tem seu vetor: ");
            int quantidadePosicoes = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[quantidadePosicoes];
            double soma = 0.0;

            for (int i = 0; i < quantidadePosicoes; i++)
            {
                Console.Write("Qual o nome da posição " + i + ": ");
                string nome = Console.ReadLine();
                Console.Write("Qual a posição da posição " + i + ": ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Produto { Nome = nome, Preco = preco };
                soma += vetor[i].Preco;
            }

            double media = soma / quantidadePosicoes;

            Console.WriteLine("Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
