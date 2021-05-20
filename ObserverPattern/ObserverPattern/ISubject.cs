using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    interface ISubject
    {
        void follow(IObserver o);
        void unfollow(IObserver o);
        void notifyObserver();
    }
}
