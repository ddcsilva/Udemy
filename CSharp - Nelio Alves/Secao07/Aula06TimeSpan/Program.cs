using System;

namespace Aula06TimeSpan
{
    public class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1;
            TimeSpan t2;
            TimeSpan t3;
            TimeSpan t4;
            TimeSpan t5;
            TimeSpan t6;

            // Construtores

            t1 = new TimeSpan();
            t2 = new TimeSpan(900000000L);
            t3 = new TimeSpan(2, 11, 21);
            t4 = new TimeSpan(1, 2, 11, 21);
            t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            // Métodos From

            t1 = TimeSpan.FromDays(1.5);
            t2 = TimeSpan.FromHours(1.5);
            t3 = TimeSpan.FromMinutes(1.5);
            t4 = TimeSpan.FromSeconds(1.5);
            t5 = TimeSpan.FromMilliseconds(1.5);
            t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
