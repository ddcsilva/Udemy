using Aula03SobreposicaoVirtualOverrideBase.Entities;
using Aula04ClassesMetodosSelados.Entities;
using System;

namespace Aula04ClassesMetodosSelados
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(1001, "Alex", 500.0);
            Conta conta2 = new ContaPoupanca(1002, "Anna", 500.0, 0.01);

            conta1.Sacar(10.0);
            conta2.Sacar(10.0);

            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta2.Saldo);
        }
    }
}
