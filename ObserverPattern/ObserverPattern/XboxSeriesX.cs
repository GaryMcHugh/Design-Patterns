using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class XboxSeriesX : Stock
    {
        public XboxSeriesX(string product, double price, int stockCount) : base(product, price, stockCount)
        {
        }
    }
}
