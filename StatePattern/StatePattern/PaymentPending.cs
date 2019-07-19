using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class PaymentPending : IOrder
    {
        Order order;

        public PaymentPending(Order newOrder)
        {
            order = newOrder;
        }
        public void CancelOrder()
        {
            Console.WriteLine("Cancelling your unpaid order.");
            order.setOrderState(order.cancelledOrder);
        }

        public void VerifyPayment()
        {
            Console.WriteLine("Your payment has been verified, We will ship your order soon!.");
            order.setOrderState(order.orderBeingPrepared);
        }

        public void ShipOrder()
        {
            Console.WriteLine("Cannot ship your order when the payment is pending");
        }
    }
}
