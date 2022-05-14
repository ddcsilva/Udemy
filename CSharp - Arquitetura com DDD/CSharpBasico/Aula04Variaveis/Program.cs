using System;

namespace Aula04Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int variavelTeste;
            variavelTeste = 123;

            Console.WriteLine("O valor da variável é: {0}", variavelTeste);

            bool variavelBooleana = false;

            if (variavelBooleana == false)
            {
                variavelTeste = 765;
            }

            Console.WriteLine("O valor da variável é: {0}", variavelTeste);

            var testeInteger = 111;
            var testeBool = true;
            var testeString = "Aula";

            Console.WriteLine(testeInteger);
            Console.WriteLine(testeBool);
            Console.WriteLine(testeString);
        }
    }
}
