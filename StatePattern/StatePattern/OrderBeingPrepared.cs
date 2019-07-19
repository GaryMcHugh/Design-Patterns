using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class OrderBeingPrepared : IOrder
    {
        Order order;

        public OrderBeingPrepared(Order newOrder)
        {
            order = newOrder;
        }
        public void CancelOrder()
        {
            Console.WriteLine("Cancelled your order.");
            order.setOrderState(order.cancelledOrder);
        }

        public void VerifyPayment()
        {
            Console.WriteLine("Already verified your payment");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Shipping your order now");
            order.setOrderState(order.orderShipped);
        }
    }
}
