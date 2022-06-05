using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Lista de Funcionários ::.");
            Console.WriteLine();
            Console.Write("Quantos funcionários deverão ser registrados? ");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < quantidadeFuncionarios; i++)
            {
                Console.WriteLine($".:: Dados do Funcionario {i} ::.");

                Console.Write("Insira o Id: ");
                int Id = int.Parse(Console.ReadLine());
                
                Console.Write("Insira o Nome: ");
                string Nome = Console.ReadLine();

                Console.Write("Insira o Salário: ");
                double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (funcionarios.Find(x => x.Id == Id) == null)
                {
                    funcionarios.Add(new Funcionario(Id, Nome, Salario));
                }
                else
                {
                    Console.WriteLine("Não foi possível efetuar o cadastro. Id do Funcionário já existe no sistema!");
                }
            }

            Console.WriteLine();

            Console.Write("Entre com o Id do Funcionário que deseja aumentar o salário: ");
            int IdFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionarioEncontrado = funcionarios.Find(x => x.Id == IdFuncionario);

            if (funcionarioEncontrado != null)
            {
                Console.Write("Entre com a porcentagem de aumento: ");
                double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarioEncontrado.AumentarSalario(Porcentagem);
            }
            else
            {
                Console.WriteLine("O Id informado não foi localizado!");
            }

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }
    }
}
