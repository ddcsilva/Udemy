using Exercicio1.Entities;
using Exercicio1.Entities.Enums;
using System;
using System.Globalization;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: DADOS DO DEPARTAMENTO ::.");
            Console.Write("Entre com o nome do departamento: ");
            string departamentName = Console.ReadLine();
            Console.WriteLine(".:: DADOS DO TRABALHADOR ::.");
            Console.Write("Nome: ");
            string workerName = Console.ReadLine();
            Console.Write("Senioridade (Junior, Pleno, Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament departament = new Departament(departamentName);
            Worker worker = new Worker(workerName, level, baseSalary, departament);

            Console.Write("Quantos contratos para este trabalhador? ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfContracts; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato nº {i}");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Entre com o mês e ano para calcular a renda: ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");
        }
    }
}
