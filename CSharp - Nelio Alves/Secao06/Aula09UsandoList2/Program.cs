using System;
using System.Collections.Generic;

namespace Aula09UsandoList2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Ana");

            lista.Insert(2, "Marco");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Total da Lista: " + lista.Count);

            Console.WriteLine();

            string s1 = lista.Find(Teste);
            Console.WriteLine("Primeiro nome com a letra A: " + s1);

            string s2 = lista.Find(x => x[0] == 'M');
            Console.WriteLine("Primeiro nome com a letra M: " + s2);

            string s3 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com a letra M: " + s3);

            int posicao1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição com a letra A: " + posicao1);

            int posicao2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição com a letra A: " + posicao2);

            Console.WriteLine("----------------------------------");

            List<string> lista2 = lista.FindAll(x => x.Length == 5);

            foreach (var item in lista2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------");

            lista.Remove("Alex");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------");

            lista.RemoveAll(x => x[0] == 'M');

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        static bool Teste(string s)
        {
            return s[0] == 'A';
        }
    }
}
