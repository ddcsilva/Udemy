using Aula02UpcastingDowncasting.Entities;
using System;

namespace Aula02UpcastingDowncasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1001, "Alex", 0.0);
            ContaComercial contaComercial = new ContaComercial(102, "Maria", 0.0, 500.0);

            // UPCASTING
            Conta conta2 = contaComercial;
            Conta conta3 = new ContaComercial(1003, "Bob", 0.0, 200.0);
            Conta conta4 = new ContaPoupanca(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            //ContaComercial conta5 = (ContaComercial)conta3; // Sintaxe Comum
            ContaComercial conta5 = conta3 as ContaComercial; // Sintaxe Alternativa
            conta5.Emprestar(100.0);
            //conta3.Emprestar(100.0); // Erro

            //ContaComercial conta6 = (ContaComercial)conta4; // Erro de Tempo de Execução

            if (conta4 is ContaComercial)
            {
                ContaComercial conta6 = (ContaComercial)conta4;
                conta6.Emprestar(200.0);
                Console.WriteLine("Empréstimo Realizado!");
            }

            if (conta4 is ContaPoupanca)
            {
                ContaPoupanca conta6 = (ContaPoupanca)conta4;
                conta6.AtualizarSaldo();
                Console.WriteLine("Conta Atualizada!");
            }
            
        }
    }
}
