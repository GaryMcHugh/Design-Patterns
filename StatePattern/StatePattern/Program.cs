using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.CancelOrder();

            order.VerifyPayment();

            order.ShipOrder();

            Console.ReadLine();
        }
    }
}
