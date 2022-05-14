using System;

namespace Aula12SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch... case (Caso)

            int x = 1;

            switch (x)
            {
                case 1:
                    Console.WriteLine("Igual a 1");
                    break;
                case 2:
                    Console.WriteLine("Igual a 2");
                    break;
                case 3:
                    Console.WriteLine("Igual a 3");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
