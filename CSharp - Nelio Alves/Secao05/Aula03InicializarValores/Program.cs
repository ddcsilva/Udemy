using System;
using System.Globalization;

namespace Aula03InicializarValores
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco);
            Produto produto2 = new Produto();
            Produto produto3 = new Produto { Nome = "TV", Preco = 500.0, Quantidade = 20 };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(quantidade);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + produto);
        }
    }
}
