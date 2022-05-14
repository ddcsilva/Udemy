using System;

namespace Aula07OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND = E   = &&
            //  OR = OU  = ||
            // NOT = NÃO = !

            bool condicao1 = true;
            bool condicao2 = false;

            Console.WriteLine(condicao1 && condicao2);
            Console.WriteLine(condicao1 || condicao2);
            Console.WriteLine(!condicao1);
            Console.WriteLine(!condicao2);
        }
    }
}
