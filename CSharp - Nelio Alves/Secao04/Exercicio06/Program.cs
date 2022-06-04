using System;

namespace Exercicio06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?");

            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar?");

            ConversorDeMoeda.MoedaDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Total a pagar: R$" + ConversorDeMoeda.Conversor().ToString("F2"));

            Console.ReadLine();
        }
    }
}
