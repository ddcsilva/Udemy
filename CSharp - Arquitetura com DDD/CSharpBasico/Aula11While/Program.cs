using System;

namespace Aula11While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                x++;

                if (x % 2 == 0)
                {
                    continue;
                }

                if (x == 7)
                {
                    break;
                }

                Console.WriteLine(x);
            }
        }
    }
}
