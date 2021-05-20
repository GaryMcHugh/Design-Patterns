using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Stock : ISubject
    {
        private string _product;
        private double _price;
        private int _stockCount;
        private List<IObserver> _observers;

        public Stock(string product, double price, int stockCount)
        {
            this._product = product;
            this._price = price;
            this._stockCount = stockCount;
            _observers = new List<IObserver>();
        }
        public void follow(IObserver newObserver)
        {
            _observers.Add(newObserver);
        }

        public void unfollow(IObserver deleteObserver)
        {
            _observers.Remove(deleteObserver);
        }

        public void notifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.update(this);
            }
            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    notifyObserver();
                }
            }
        }

        public int StockCount
        {
            get { return _stockCount; }
            set
            {
                if (_stockCount != value)
                {
                    _stockCount = value;
                    notifyObserver();
                }
            }
        }

        public string Product
        {
            get { return _product; }
        }
    }
}
