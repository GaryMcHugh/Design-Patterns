using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Customer : IObserver
    {
        private string _name;
        private Stock _stock;

        public Customer(string name)
        {
            this._name = name;
        }

        public void update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                              "change to stock({3}) or price ({2})", _name, stock.Product, stock.Price, stock.StockCount);
        }

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
