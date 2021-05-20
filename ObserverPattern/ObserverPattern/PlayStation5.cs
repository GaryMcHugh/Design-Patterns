using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class PlayStation5 : Stock
    {
        public PlayStation5(string product, double price, int stockCount) : base(product, price, stockCount)
        {
        }
    }
}
