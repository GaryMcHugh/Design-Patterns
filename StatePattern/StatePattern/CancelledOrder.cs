using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class CancelledOrder : IOrder
    {
        Order order;

        public CancelledOrder(Order newOrder)
        {
            order = newOrder;
        }
        public void CancelOrder()
        {
            Console.WriteLine("Your order has already been cancelled.");
        }

        public void VerifyPayment()
        {
            Console.WriteLine("Order cancelled, you cannot verify payment.");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order cannot be shipped, it was cancelled.");
        }
    }
}
