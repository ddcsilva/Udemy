using System;
using System.Globalization;

namespace Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();
            double mediaSalario;

        Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaSalario = (funcionario1.Salario + funcionario2.Salario) / 2;
            Console.WriteLine("Salário Médio: " + mediaSalario);
        }
    }
}
