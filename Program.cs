using System;
using Enumecomp0.Entities;
using Enumecomp0.Entities.Enums;


namespace Enumecomp0
{
    internal class Program
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
        }
    }
}
