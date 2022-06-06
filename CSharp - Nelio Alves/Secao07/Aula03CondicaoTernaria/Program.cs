using System;

namespace Aula03CondicaoTernaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            double preco = 34.5;
            double desconto;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            double preco2 = 34.5;
            double desconto2 = (preco2 < 20.0) ? preco2 * 0.1 : preco2 * 0.05;

            Console.WriteLine(desconto);
            Console.WriteLine(desconto2);
        }
    }
}
