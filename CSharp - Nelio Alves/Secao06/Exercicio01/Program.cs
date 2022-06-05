using System;

namespace Exercicio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            AluguelQuarto[] quarto = new AluguelQuarto[9];
            Console.Write("Quantos quartos você gostaria de alugar? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.Write("Qual o nome do estudante? ");
                string Nome = Console.ReadLine();
                Console.Write("Qual o email do estudante? ");
                string Email = Console.ReadLine();
                Console.Write("Qual quarto [0-9] deseja reservar? ");
                int NumeroQuarto = int.Parse(Console.ReadLine());

                quarto[NumeroQuarto] = new AluguelQuarto(Nome, Email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < quarto.Length; i++)
            {
                if (quarto[i] != null)
                {
                    Console.WriteLine(i + ": " + quarto[i]);
                }
            }
        }
    }
}
