using System;
using System.Globalization;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente;

            Console.WriteLine(".:: Banco Sharp ::.");
            Console.WriteLine();

            Console.Write("Entre o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string TitularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string DepositoInicial = Console.ReadLine();

            if (!string.IsNullOrEmpty(DepositoInicial) && DepositoInicial.ToUpper() == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaCorrente = new ContaCorrente(NumeroConta, TitularConta, Saldo);
            }
            else
            {
                contaCorrente = new ContaCorrente(NumeroConta, TitularConta);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaCorrente);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            contaCorrente.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaCorrente);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            contaCorrente.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaCorrente);
            Console.WriteLine();
        }
    }
}
