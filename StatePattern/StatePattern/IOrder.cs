using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    interface IOrder
    {

        void CancelOrder();
        void VerifyPayment();
        void ShipOrder();
    }
}
