using Aula01Enumeracoes.Entities;
using Aula01Enumeracoes.Entities.Enums;
using System;

namespace Aula01Enumeracoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string statusString = OrderStatus.PendingPayment.ToString();
            OrderStatus statusString2 = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(statusString);
            Console.WriteLine(statusString2);
        }
    }
}
