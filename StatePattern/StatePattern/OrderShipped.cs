using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class OrderShipped : IOrder
    {
        Order order;

        public OrderShipped(Order newOrder)
        {
            order = newOrder;
        }
        public void CancelOrder()
        {
            Console.WriteLine("You cannot cancel your order, already shipped.");
        }

        public void VerifyPayment()
        {
            Console.WriteLine("Payment already verified, order has been shipped");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Your order has already been shipped");
        }
    }
}
