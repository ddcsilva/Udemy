using System;

namespace Aula07LacoForeach
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Alex", "Bob" };

            foreach (string item in vetor)
            {
                Console.WriteLine(item);
            }
        }
    }
}
