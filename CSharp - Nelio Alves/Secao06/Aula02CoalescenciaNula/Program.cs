using System;

namespace Aula02CoalescenciaNula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            double number1 = x ?? 5;
            double number2 = y ?? 5;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}
