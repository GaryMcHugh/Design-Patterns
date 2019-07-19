using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class Order
    {
        public IOrder cancelledOrder;
        public IOrder paymentPending;
        public IOrder orderShipped;
        public IOrder orderBeingPrepared;

        public IOrder orderState;

        public Order()
        {
            cancelledOrder = new CancelledOrder(this);
            paymentPending = new PaymentPending(this);
            orderShipped = new OrderShipped(this);
            orderBeingPrepared = new OrderBeingPrepared(this);

            orderState = paymentPending;
        }

        public void setOrderState(IOrder newOrderState)
        {
            orderState = newOrderState;
        }
        
        public void CancelOrder()
        {
            orderState.CancelOrder();
        }
        public void VerifyPayment()
        {
            orderState.VerifyPayment();
        }

        public void ShipOrder()
        {
            orderState.ShipOrder();
        }
    }
}
