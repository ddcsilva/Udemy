using Aula01Heranca.Entities;
using System;

namespace Aula01Heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaComercial conta = new ContaComercial(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(conta.Saldo);
        }
    }
}
